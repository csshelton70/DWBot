# DWBot
Discord bot for Dungeon World games

# Adding the DWBot to your Discord Server
blah blah

# Commands
* !help				    Gives a list of commands
* !help <cmd>		    More details about command <cmd>
* !roll <xdy>			    Rolls a dice based on the format string <xdy>
* !rollstat <stat>	    Rolls based on character sheet
* !rollmove <name>      Rolls the move indicated in command and returns appropriate result
* !moves dm			    Displays a list of dm moves	
* !moves dungeon        Displays a list of dungeon moves
* !moves player		    Displays a list of moves (generic and your character class )
* !moves special        Displays a list of special moves
* !moves help <name>    Returns detailed information about the move.
* !newcharacter		    walks the user through creating a new character
* !character			Displays character information
* !set <stat> <x>	    Set the value of a <stat> to <x>
* !shift <stat> <+/-x>  Adjusts the value of a <stat> by <x>
* !endSession			Ends the sessions and prompts a user for XP advancement
* !addXp				Adds 1 XP to character sheet

#Stats that can be adjusted
* str
* int
* wis
* dex
* con
* cha
* xp

# Running your own copy of the bot
1. Clone the repo
2. Go to the discord developer portal and register your own bot and retrieve the token
   - Never share this token as it would allow others to hijack your bot
3. Create a app.config (see below ) in the solution folder and use your personal keys
4. Build and run

## app.config example
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>

    <add key="discord_token" value="generated from discord dev site"/>
    <add key="discord_prefix" value="!"/>
    <add key="discord_logging" value="information"/>
    <!--
      logging options: none, critical, error, warning, information, debug, trace
    -->

  </appSettings>
</configuration>
```

# Resources used
*  [DSharpPlus](https://github.com/DSharpPlus/DSharpPlus)
*  [DiceRoller](https://github.com/skizzerz/DiceRoller)
*  [Emojis] (https://emojipedia.org/twitter/)


## Nuget Commands to install Packages
* Install-Package DSharpPlus
* Install-Package DSharpPlus.CommandsNext
* Install-Package DSharpPlus.Interactivity
* Install-Package DiceRoller

# Acknowledgements
Thanks to:
* [Sage LaTorra and Adam Koebel for creating the Dungeon World game.](https://dungeon-world.com/)
* [Meguey Baker and Vincent Baker for creating the Apocalypse Worlds and the Powered by the Apocalypse (PbtA) concept.](http://apocalypse-world.com/)
* [Mileszs: Json data](https://github.com/mileszs/dungeon-world-data)
* [Vindexus: Json data](https://github.com/Vindexus/DungeonWorldData)
* [BotheredByBees: Json data](https://github.com/botheredbybees/dungeonworld)
* []()A


