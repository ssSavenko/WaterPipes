using System;

namespace WaterPipes
{
    class PrintableField : IPrintaleField
    {
        private readonly Field fieldForPrint;

        private char symbolOfBounds = '+';
        private char symbolOfCellWithPipe = '0';
        private char symbolOfSourceCell = 'S';
        private char symbolOfEmptyCell = ' ';

        public  PrintableField(Field inputedField)
        {
            fieldForPrint = inputedField;
        }

        public Field GetFieldForPrint
        {
            get { return fieldForPrint; }
        }

        public void PrintField()
        {
            for(int i = 0; i <= fieldForPrint.Height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (i == 0 || i == fieldForPrint.Height)
                {
                    for (int k = 0; k <= fieldForPrint.Width; k++)
                    {
                        Console.Write(symbolOfBounds);
                    }
                }
                else
                {
                    for (int j = 0; j <= fieldForPrint.Width; j++)
                    {
                        if (j == 0 || j == GetFieldForPrint.Width)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(symbolOfBounds);
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
