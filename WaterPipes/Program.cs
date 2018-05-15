using System;

namespace WaterPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Field myf = new Field(10, 10);
            PrintableFieldWithCursor a = new PrintableFieldWithCursor(myf, new Cursor(10,10));
            a.PrintFieldWithCursor();
        }
    }
}