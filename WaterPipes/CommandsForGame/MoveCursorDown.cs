using System;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorDown : ICommandForGame
    {
        private Cursor cursorForChanges;

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