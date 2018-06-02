using System;

namespace WaterPipes.CommandsForGame
{
    internal class ClearCell : ICommandForGame
    {
        private Cursor cursorForChanges;
        private Field fieldForChanges;

        public ClearCell(Field inputedField, Cursor inputedCursor)
        {
            fieldForChanges = inputedField;
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Delete)
            {
                fieldForChanges[cursorForChanges.YCordinate, cursorForChanges.XCordinate] = Cell.CellIsEmpty;
            }
        }
    }
}