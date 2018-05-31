using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorRight : ICommandForGame
    {
        Cursor cursorForChanges;

        public MoveCursorRight(Cursor inputedCursor)
        {
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.RightArrow)
            {
                cursorForChanges.XCordinate += 1;
            }
        }
    }
}
