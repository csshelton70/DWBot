using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace DWBot.Commands
{
    [Group("moves")]
    [Description("Moves Commands")]

    public class MovesCommand : BaseCommandModule
    {
        [Command("gm")]
        [Description("Returns a list of GM Moves")]
        [Aliases("dm")]
        public async Task GMMoves(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":fire:");
            var builder = new DiscordEmbedBuilder
            {
                Title = "GM Moves",
                Color = DiscordColor.Azure,    
                 Url= "https://www.dungeonworldsrd.com/gamemastering/"

            };

            builder.AddField("Use a monster, danger, or location move", "Every monster in an adventure has moves associated with it, as do many locations", false);
            builder.AddField("Reveal an unwelcome truth", "An unwelcome truth is a fact the players wish wasn’t true.", false);
            builder.AddField("Show signs of an approaching threat", "With this move, you just show them that something’s going to happen unless they do something about it.", false);
            builder.AddField("Deal damage", "When you deal damage, choose one source of damage that’s fictionally threatening a character and apply it.", false);
            builder.AddField("Use up their resources", "With this move, something happens to use up some resource: weapons, armor, healing, ongoing spells.", false);
            builder.AddField("Turn their move back on them", "Think about the benefits a move might grant a character and turn them around in a negative way.", false);
            builder.AddField("Separate them", "Separating the characters can mean anything from being pushed apart in the heat of battle to being teleported to the far end of the dungeon.", false);
            builder.AddField("Give an opportunity that fits a class’ abilities", "Present an opportunity that plays to what one class shines at.", false);
            builder.AddField("Show a downside to their class, race, or equipment", "Just as every class shines, they all have their weaknesses too.", false);
            builder.AddField("Offer an opportunity, with or without cost", "Show them something they want: riches, power, glory. If you want, you can associate some cost with it too, of course.", false);
            builder.AddField("Put someone in a spot", "A spot is someplace where a character needs to make tough choices.", false);
            builder.AddField("Tell them the requirements or consequences and ask", "This move is particularly good when they want something that’s not covered by a move, or they’ve failed a move. They can do it, sure, but they’ll have to pay the price.", false);

            builder.AddField("Dungeon Moves", "check out !moves dungeon", true);

            await ctx.RespondAsync(builder);
        }

        [Command("dungeon")]
        [Description("Returns a list of Dungeon Moves")]
        public async Task DungeonMoves(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":fire:");
            var builder = new DiscordEmbedBuilder
            {
                Title = "Dungeon Commands",
                Color = DiscordColor.Azure,
                Url = "https://www.dungeonworldsrd.com/gamemastering/"

            };

            builder.AddField("Change the environment", "The environment is the general feel of the area the players are in: carved tunnels, warped trees, safe trails, or whatever else. This is your opportunity to introduce them to a new environment.", false);
            builder.AddField("Point to a looming threat", "If you know that something is lurking and waiting for the players to stumble upon it, this move shows them the signs and clues.", false);
            builder.AddField("Introduce a new faction or type of creature", "A type of creature is a broad grouping: orcs, goblins, lizardmen, the undead, etc.  Once you introduce them you can begin to make moves and cause trouble for the players with those creatures or NPCs.", false);
            builder.AddField("Use a threat from an existing faction or type of creature", "Once the characters have been introduced to the presence of a faction or type of creature you can use moves of monsters of that type.", false);
            builder.AddField("Make them backtrack", "Look back at the spaces you’ve added to the map. Is there anything useful there as yet undiscovered? Can you add a new obstacle that can only be overcome by going back there?", false);
            builder.AddField("Present riches at a price", "Find a way to make what they want available if they give up what they have.", false);
            builder.AddField("Present a challenge to one of the characters", "Challenge a character by looking at what they’re good at -or- by looking at what they’re bad at or what they’ve left unresolved.", false);
            

            await ctx.RespondAsync(builder);
        }
    }
}
