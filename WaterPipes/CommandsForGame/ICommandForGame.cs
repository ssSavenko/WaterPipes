using System;

namespace WaterPipes.CommandsForGame
{
    interface ICommandForGame
    {
        void PerformCommand(ConsoleKey inputedKey);
    }
}
