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
            for (int i = 0; i <= GetFieldForPrint.Height + 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == 0 || i == GetFieldForPrint.Height+1)
                {
                    for (int k = 0; k <= GetFieldForPrint.Width +1; k++)
                    {
                        Console.Write(symbolOfBounds);
                    }
                }
                else
                {
                    for (int j = -1; j <= GetFieldForPrint.Width; j++)
                    {
                        if (j == -1 || j == GetFieldForPrint.Width)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfBounds);
                        }
                        else if (cursorForPrint.XCordinate == j && cursorForPrint.YCordinate + 1 == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(symbolOfCursor);
                        }
                        else if (GetFieldForPrint[i - 1, j] == Cell.CellContainsPipe)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (GetFieldForPrint[i - 1, j] == Cell.CellContainsPipeWithWater)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (GetFieldForPrint[i - 1, j] == Cell.CellContainsSource)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(symbolOfSourceCell);
                        }
                        else if (GetFieldForPrint[i - 1, j] == Cell.CellIsEmpty)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfEmptyCell);
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}