using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorDown : ICommandForGame
    {
        Cursor cursorForChanges;

        public MoveCursorDown(Cursor inputedCursor)
        {
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.DownArrow)
            {
                cursorForChanges.YCordinate += 1;
            }
        }
    }
}