﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereOS.Logging
{
    internal class LogEvent
    {
        public LogEvent(LogPriority priority, string source, string message)
        {
            Priority = priority;
            Source = source;
            Message = message;
        }

        internal LogPriority Priority { get; private set; }

        internal string Source { get; private set; }

        internal string Message { get; private set; }

        internal DateTime Date { get; } = DateTime.Now;

        internal void Print()
        {
            switch (Priority)
            {
                case LogPriority.Info:
                    Util.Print(ConsoleColor.Cyan, "[Info]");
                    break;
                case LogPriority.Warning:
                    Util.Print(ConsoleColor.Yellow, "[Warning]");
                    break;
                case LogPriority.Error:
                    Util.Print(ConsoleColor.Red, "[Error]");
                    break;
            }
            Console.Write(" ");
            Util.Print(ConsoleColor.White, Date.ToString("HH:mm"));
            Util.PrintLine(ConsoleColor.White, $" - {Source}: {Message}");
        }
    }
}
