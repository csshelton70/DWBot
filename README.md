# DWBot
Discord bot for Dungeon World games

# Running your own copy of the bot
1. Clone the repo
2. Go to the discord developer portal and register your own bot and retrieve the token
   - Never share this token as it would allow others to hijack your bot
3. Create a app.config (see below ) in the solution folder and use your personal keys

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
