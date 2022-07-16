using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DWBot.Commands;
using Emzi0767.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static string discordBotToken;


        static void Main(string[] args)
        {
            discordBotToken = ConfigurationManager.AppSettings["discord_token"];
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var config = new DiscordConfiguration()
            {
                Token = discordBotToken,
                TokenType = TokenType.Bot,
                MinimumLogLevel = LogLevel.Debug,
                // Critical, Error, Warning, Information,Debug, Trace
                //Intents = DiscordIntents.All
            };

            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" }
            };

            var discord = new DiscordClient(config);

            var commands = discord.UseCommandsNext(commandsConfig);

            commands.RegisterCommands<ClassDiceRollerCommand>();

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

    }
}
