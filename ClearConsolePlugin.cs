using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;

namespace Espcevan.ClearConsole
{
    public class ClearConsole : RocketPlugin
    {
        public static ClearConsole Instance;
        public static string PluginName = "BuilderMode";
        public static string PluginVersion = " 1.0.0";
        protected override void Load()
        {
            Instance = this;
            Logger.Log("ClearConsole has been loaded!");
            Logger.Log(PluginName + PluginVersion, ConsoleColor.Yellow);
            Logger.Log("Made by Espcevan", ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            Instance = null;
            Logger.Log("BuilderMode has been unloaded!");
            Logger.Log("Visit Tortellio Discord for more! https://discord.gg/pzQwsew", ConsoleColor.Yellow);
        }
    }
}