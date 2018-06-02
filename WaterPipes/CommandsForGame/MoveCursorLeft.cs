using System;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorLeft : ICommandForGame
    {
        private Cursor cursorForChanges;

        public MoveCursorLeft(Cursor inputedCursor)
        {
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.LeftArrow)
            {
                cursorForChanges.XCordinate -= 1;
            }
        }
    }
}