using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForGame
{
    internal class AddSource : ICommandForGame
    {
        Cursor cursorForChanges;
        Field fieldForChanges;

        public AddSource(Field inputedField, Cursor inputedCursor)
        {
            fieldForChanges = inputedField;
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.S)
            {
                fieldForChanges[cursorForChanges.YCordinate, cursorForChanges.XCordinate] = Cell.CellContainsSource;
            }
        }
    }
}