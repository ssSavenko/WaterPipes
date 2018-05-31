using System;
using System.Threading;

namespace WaterPipes
{
    internal class Game
    {
        private int height;
        private int width;
        private int pause;

        private Cursor gameCursor;
        private Field gameField;
        private IPrintableFieldWithCursor gamePrintableField;
        private IsGameHasToStart isGameHasToStart;
        private GameIteration gameIterations;
        private CommandCollection commands;

        public Game(int inputedWidth, int inputedHeight, int inputedPause)
        {
            height = inputedHeight;
            width = inputedWidth;
            pause = inputedPause;

            gameCursor = new Cursor(width, height);
            gameField = new Field(height, width);
            gamePrintableField = new PrintableFieldWithCursor(gameField, gameCursor);
            gameIterations = new GameIteration(gameField);
            isGameHasToStart = new IsGameHasToStart();
            commands = new CommandCollection(gameField, gameCursor, isGameHasToStart);
        }
        
        public void Run()
        {
            while (!isGameHasToStart.IsGameReady)
            {
                gamePrintableField.PrintFieldWithCursor();
                Console.Clear();
                gamePrintableField.PrintFieldWithCursor();
                commands.PerformCommands(Console.ReadKey().Key);
            }

            Console.Clear();
            gamePrintableField.PrintField();

            while (gameIterations.ChangeField())
            {
                Console.Clear();
                gamePrintableField.PrintField();
                Thread.Sleep(pause);
            }
        }
    }
}
