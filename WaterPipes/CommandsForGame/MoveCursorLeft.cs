﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorLeft : ICommandForGame
    {
        Cursor cursorForChanges;

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