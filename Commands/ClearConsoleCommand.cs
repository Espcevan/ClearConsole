using Rocket.API;
using System;
using System.Collections.Generic;

namespace Espcevan.ClearConsole.Commands
{
    public class ClearConsole : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Console;

        public string Name => "clear";

        public string Help => "This command will clear the console.";

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "console.clear" };

        public void Execute( IRocketPlayer caller, string[] command )
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your Console has been Cleaned.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("############################################################################");
            Console.WriteLine("## dP     dP            dP                                             dP ##");
            Console.WriteLine("## 88     88            88                                             88 ##");
            Console.WriteLine("## 88     88 88d888b. d8888P dP    dP 88d888b. 88d888b. .d8888b. .d888b88 ##");
            Console.WriteLine("## 88     88 88'  `88   88   88    88 88'  `88 88'  `88 88ooood8 88'  `88 ##");
            Console.WriteLine("## Y8.   .8P 88    88   88   88.  .88 88       88    88 88.  ... 88.  .88 ##");
            Console.WriteLine("## `Y88888P' dP    dP   dP   `88888P' dP       dP    dP `88888P' `88888P8 ##");
            Console.WriteLine("############################################################################");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Read();
        }
    }
}