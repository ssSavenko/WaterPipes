using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForCursor
{
    internal class AddPipe : ICommandForGame
    {
        Field fieldForChanges;
        Cursor cursorForChanges;

        public AddPipe(Field inputedField, Cursor inputedCursor)
        {
            fieldForChanges = inputedField;
            cursorForChanges = inputedCursor;
        }

        public void performCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Enter)
            {
                fieldForChanges[cursorForChanges.YCordinate, cursorForChanges.XCordinate] = Cell.CellContainsPipe;
            }
        }
    }
}
