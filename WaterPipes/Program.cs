using System;

namespace WaterPipes
{
    internal class Program
    {
        public static void Main()
        {
            Game waterPipeGame = new Game( 30, 15, 400);
            waterPipeGame.Run();
        }
    }
}