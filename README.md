# DWBot
Discord bot for Dungeon World games

# Adding the DWBot to your Discord Server
blah blah

# Commands
* !help				Gives a list of commands
* !help <cmd>			More command details
* !roll xdy			Rolls a dice xdy
* !rollstat <stat>	Rolls based on character sheet
* !dmmoves			Displays a list of dm moves	
* !moves				displays a list of moves (generic and your class )
* !newcharacter		walks the user through creating a new character
* !character			Displays character information
* !set <stat> x		Set the value of a stat
* !shift <stat> +/-	Adjusts the value of a stat
* !endSession			Ends the sessions and prompts a user for XP advancement
* !addXp				Adds 1 XP to character sheet

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

# Libraries used
*  [DSharpPlus](https://github.com/DSharpPlus/DSharpPlus)
*  [DiceRoller](https://github.com/skizzerz/DiceRoller)


## Nuget Commands to install Packages
* Install-Package DSharpPlus
* Install-Package DSharpPlus.CommandsNext
* Install-Package DSharpPlus.Interactivity
* Install-Package DiceRoller

# Acknowledgements
Thanks to:
* [Sage LaTorra and Adam Koebel for creating the Dungeon World game.](https://dungeon-world.com/)
* [Meguey Baker and Vincent Baker for creating the Apocalypse Worlds and the Powered by the Apocalypse (PbtA) concept.](http://apocalypse-world.com/)
* 

