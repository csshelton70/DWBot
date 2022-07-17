using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Exceptions;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.Extensions;
using DSPlus.Examples;
using DWBot.Commands;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public readonly EventId BotEventId = new EventId(42, "Bot-Ex01");
        public DiscordClient discord { get; set; }
        public CommandsNextExtension commands { get; set; }
        public InteractivityExtension interactivity { get; set; }

        public static void Main(string[] args)
        {
            //Pass control to Async function
            var prog = new Program();
            prog.MainAsync().GetAwaiter().GetResult();
        }

        public async Task MainAsync()
        {
            //set config values
            var config = new DiscordConfiguration()
            {
                Token = ConfigurationManager.AppSettings["discord_token"],
                TokenType = TokenType.Bot,
                MinimumLogLevel = GetLoggingLevel(),

                AutoReconnect = true
            };

            //set prefix character(s)
            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { ConfigurationManager.AppSettings["discord_prefix"] },
                EnableDms = true,
                EnableMentionPrefix = true
            };

            //Create the client
            discord = new DiscordClient(config);

            discord.UseInteractivity(new InteractivityConfiguration
            {
                // default pagination behaviour to just ignore the reactions
                PaginationBehaviour = PaginationBehaviour.Ignore,

                // default timeout for other actions to 2 minutes
                Timeout = TimeSpan.FromMinutes(2)
            });

            //Enable commands
            commands = discord.UseCommandsNext(commandsConfig);

            //Register all commands to be used
            commands.RegisterCommands<DiceRollerCommand>();

            commands.RegisterCommands<ExampleUngrouppedCommands>();
            commands.RegisterCommands<ExampleGrouppedCommands>();
            commands.RegisterCommands<ExampleExecutableGroup>();
            commands.RegisterCommands<ExampleInteractiveCommands>();


            discord.Ready += this.Client_Ready;
            discord.GuildAvailable += this.Client_GuildAvailable;
            discord.ClientErrored += this.Client_ClientError;
            commands.CommandExecuted += this.Commands_CommandExecuted;
            commands.CommandErrored += this.Commands_CommandErrored;


            discord.Logger.LogInformation($"Prefix    :{ConfigurationManager.AppSettings["discord_prefix"]}");
            discord.Logger.LogInformation($"Log Level :{ConfigurationManager.AppSettings["discord_logging"]}");

            //Start the bot
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }


        private Task Client_Ready(DiscordClient sender, ReadyEventArgs e)
        {
            // log the fact that this event occured
            sender.Logger.LogInformation(BotEventId, "Client is ready to process events.");
            return Task.CompletedTask;
        }

        private Task Client_GuildAvailable(DiscordClient sender, GuildCreateEventArgs e)
        {
            // log the name of the guild that was just sent to our client
            sender.Logger.LogInformation(BotEventId, $"Guild available: {e.Guild.Name}");
            return Task.CompletedTask;
        }

        private Task Client_ClientError(DiscordClient sender, ClientErrorEventArgs e)
        {
            // log the details of the error that just occured in our client
            sender.Logger.LogError(BotEventId, e.Exception, "Exception occured");
            return Task.CompletedTask;
        }

        private Task Commands_CommandExecuted(CommandsNextExtension sender, CommandExecutionEventArgs e)
        {
            // log the name of the command and user
            e.Context.Client.Logger.LogInformation(BotEventId, $"{e.Context.Guild.Name}:{e.Context.User.Username} successfully executed '{e.Command.QualifiedName}'");
            return Task.CompletedTask;
        }

        private async Task Commands_CommandErrored(CommandsNextExtension sender, CommandErrorEventArgs e)
        {
            string cmd = e.Command?.QualifiedName ?? e.Context.Message.Content;

            if (e.Command?.QualifiedName == null)
            {
                // log the error details
                e.Context.Client.Logger.LogError(BotEventId, $"{e.Context.Guild.Name}:{e.Context.User.Username} tried executing '{e.Context.Message.Content}' but command does not exist", DateTime.Now);
            }
            else
            {
                e.Context.Client.Logger.LogError(BotEventId, $"{e.Context.Guild.Name}:{e.Context.User.Username} tried executing '{e.Command?.QualifiedName ?? "<unknown command>"}' but it errored: {e.Exception.GetType()}: {e.Exception.Message ?? "<no message>"}", DateTime.Now);
            }

            // let's check if the error is a result of lack
            // of required permissions
            if (e.Exception is ChecksFailedException ex)
            {
                // yes, the user lacks required permissions, 
                // let them know

                var emoji = DiscordEmoji.FromName(e.Context.Client, ":no_entry:");

                // let's wrap the response into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Access denied",
                    Description = $"{emoji} You do not have the permissions required to execute this command.",
                    Color = new DiscordColor(0xFF0000) // red
                };
                await e.Context.RespondAsync(embed);
            }
            else if (e.Exception is DSharpPlus.CommandsNext.Exceptions.CommandNotFoundException)
            {
                var emoji = DiscordEmoji.FromName(e.Context.Client, ":no_entry:");

                // let's wrap the response into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Unknown Command",
                    Description = $"{emoji} Command was not recognized:{cmd}",
                    Color = new DiscordColor(0xFF0000) // red
                };
                await e.Context.RespondAsync(embed);
            }
            else
            {
                var emoji = DiscordEmoji.FromName(e.Context.Client, ":no_entry:");

                // let's wrap the response into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Unknown Command",
                    Description = $"{emoji} Command Failed for unknown reason",
                    Color = new DiscordColor(0xFF0000) // red
                };
                await e.Context.RespondAsync(embed);
            }
        }

        private LogLevel GetLoggingLevel()
        {
            var value = ConfigurationManager.AppSettings["discord_logging"].ToLower();

            switch (value)
            {
                case "none": return LogLevel.None;
                case "trace": return LogLevel.Trace;
                case "debug": return LogLevel.Debug;
                case "information": return LogLevel.Information;
                case "warning": return LogLevel.Warning;
                case "error": return LogLevel.Error;
                case "critical": return LogLevel.Critical;
                default: return LogLevel.Debug;
            }
        }

    }
}
