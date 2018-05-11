using System;

namespace WaterPipes
{
    class PrintableFieldWithCursor : PrintableField, IPrintableFieldWithCursor
    {
        private readonly Cursor cursorForPrint;

        private char symbolOfBounds = '+';
        private char symbolOfCellWithPipe = '0';
        private char symbolOfCurs = 'X';
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
                            Console.Write(symbolOfBounds);
                        }
                        else if (GetFieldForPrint[i, j] == Cell.CellContainsPipe)
                        {
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (GetFieldForPrint[i, j] == Cell.CellContainsSource)
                        {
                            Console.Write(symbolOfSourceCell);
                        }
                        else
                        {
                            Console.Write(symbolOfEmptyCell);
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
