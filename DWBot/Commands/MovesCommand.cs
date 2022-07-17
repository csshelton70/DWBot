using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace DWBot.Commands
{
    public class MovesCommand : BaseCommandModule
    {
        [Command("gmmoves")]
        [Description("Returns a list of GM Moves")]
        [Aliases("dmmoves")]
        public async Task gmmoves(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":fire:");
            var builder = new DiscordEmbedBuilder
            {
                Title = "GM Commands",
                Color = DiscordColor.Azure,
                Description = "description\r\n* 1\r\n- 2",
               

            };

            builder.AddField("name", "inline treue", true);
            builder.AddField("name", "inline false", false);


            await ctx.RespondAsync(builder);
        }
    }
}
