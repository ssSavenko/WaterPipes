using System;

namespace WaterPipes.CommandsForGame
{
    internal interface ICommandForGame
    {
        void PerformCommand(ConsoleKey inputedKey);
    }
}