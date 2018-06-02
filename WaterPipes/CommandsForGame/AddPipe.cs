using System;

namespace WaterPipes.CommandsForGame
{
    internal class AddPipe : ICommandForGame
    {
        private Cursor cursorForChanges;
        private Field fieldForChanges;

        public AddPipe(Field inputedField, Cursor inputedCursor)
        {
            fieldForChanges = inputedField;
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Enter)
            {
                fieldForChanges[cursorForChanges.YCordinate, cursorForChanges.XCordinate] = Cell.CellContainsPipe;
            }
        }
    }
}