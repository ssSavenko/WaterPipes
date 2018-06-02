using System;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorUp : ICommandForGame
    {
        Cursor cursorForChanges;

        public MoveCursorUp(Cursor inputedCursor)
        {
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.UpArrow)
            {
                cursorForChanges.YCordinate -= 1;
            }
        }
    }
}