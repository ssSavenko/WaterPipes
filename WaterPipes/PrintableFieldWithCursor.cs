using System;

namespace WaterPipes
{
    class PrintableFieldWithCursor : PrintableField, IPrintableFieldWithCursor
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
            for (int i = 0; i <= GetFieldForPrint.Height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == 0 || i == GetFieldForPrint.Height)
                {
                    for (int k = 0; k <= GetFieldForPrint.Width; k++)
                    {
                        Console.Write(symbolOfBounds);
                    }
                }
                else
                {
                    for (int j = 0; j <= GetFieldForPrint.Width; j++)
                    {
                        if (j == 0 || j == GetFieldForPrint.Width)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfBounds);
                        }
                        else if (cursorForPrint.XCordinate + 1 == j && cursorForPrint.YCordinate + 1 == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(symbolOfCursor);
                        }
                        else if (GetFieldForPrint[i, j] == Cell.CellContainsPipe)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (GetFieldForPrint[i, j] == Cell.CellContainsPipeWithWater)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (GetFieldForPrint[i, j] == Cell.CellContainsSource)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(symbolOfSourceCell);
                        }
                        else
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
