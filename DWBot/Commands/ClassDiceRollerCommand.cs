using Dice;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DWBot.Commands
{
    public class ClassDiceRollerCommand : BaseCommandModule
    {
        public Random Rng { private get; set; }


        [Command("roll")]
        public async Task GreetCommand(CommandContext ctx, string cmd)
        {
            RollResult result = Roller.Roll(cmd);
            await ctx.RespondAsync(string.Format("Dice Rolled [{0}] = {1}", BuildResult(result), result.Value));
        }

        private string BuildResult(RollResult diceResult)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DieResult die in diceResult.Values)
            {
                if (die.DieType == DieType.Special)
                {
                    switch ((SpecialDie)die.Value)
                    {
                        case SpecialDie.Add:
                            sb.Append(" + ");
                            break;
                        case SpecialDie.Subtract:
                            sb.Append(" - ");
                            break;
                        case SpecialDie.Multiply:
                            sb.Append(" * ");
                            break;
                        case SpecialDie.Divide:
                            sb.Append(" / ");
                            break;
                        case SpecialDie.OpenParen:
                            sb.Append("(");
                            break;
                        case SpecialDie.CloseParen:
                            sb.Append(")");
                            break;
                    }
                }
                else
                {
                    sb.Append(die.Value);
                }
            }

            return sb.ToString();
        }

    }
}
