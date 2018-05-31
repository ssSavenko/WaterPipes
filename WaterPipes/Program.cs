using System;

namespace WaterPipes
{
    class Program
    {
        static void Main()
        {
            Game waterPipeGame = new Game(10, 10, 400);
            waterPipeGame.Run();
        }
    }
}