using System;

namespace WaterPipes
{
    internal class Program
    {
        static public void Main()
        {
            Game waterPipeGame = new Game( 30, 15, 400);
            waterPipeGame.Run();
        }
    }
}