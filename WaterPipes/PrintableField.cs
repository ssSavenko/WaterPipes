using System;

namespace WaterPipes
{
    class PrintableField : IPrintaleField
    {
        private char symbolOfBounds = '+';
        private char symbolOfCellWithPipe = '0';
        private char symbolOfSourceCell = 'S';
        private char symbolOfEmptyCell = ' ';
        private Field fieldForPrint;

        public  PrintableField(int height, int width)
        {
            fieldForPrint = new Field(height, width);
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
                        if (j == 0 || j == fieldForPrint.Width)
                        {
                            Console.Write(symbolOfBounds);
                        }
                        else if (fieldForPrint[i, j] == Cell.CellContainsPipe)
                        {
                            Console.Write(symbolOfCellWithPipe);
                        }
                        else if (fieldForPrint[i, j] == Cell.CellContainsSource)
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
