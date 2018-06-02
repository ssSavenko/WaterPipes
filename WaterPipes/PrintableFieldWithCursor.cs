using System;

namespace WaterPipes
{
    internal class PrintableFieldWithCursor : PrintableField, IPrintableFieldWithCursor
    {
        private readonly Cursor cursorForPrint;

        private char symbolOfBounds = '+';
        private char symbolOfCellWithPipe = '0';
        private char symbolOfCursor = 'X';
        private char symbolOfSourceCell = 'S';
        private char symbolOfEmptyCell = ' ';

        public PrintableFieldWithCursor(Field inputedField, Cursor inputedCursor) : base (inputedField)
        {
            cursorForPrint = inputedCursor;
        }

        public void PrintFieldWithCursor()
        {
            int startCursorYPosition = Console.CursorTop + 1;
            int startCursorXPosition = Console.CursorLeft + 1;
            PrintField();

            Console.SetCursorPosition(cursorForPrint.XCordinate + startCursorXPosition, cursorForPrint.YCordinate + startCursorYPosition);
            Console.Write(symbolOfCursor);
        }
    }
}