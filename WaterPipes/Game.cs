using System;
using System.Threading;

namespace WaterPipes
{
    internal class Game
    {
        private int countOfSteps;
        private int height;
        private int pause;
        private int width;
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
                Console.Clear();
                ShowCountOfSteps();
                gamePrintableField.PrintFieldWithCursor();
                commands.PerformCommands(Console.ReadKey().Key);
            }

            while (gameIterations.ChangeField())
            {
                countOfSteps++;
                Console.Clear();
                ShowCountOfSteps();
                gamePrintableField.PrintField();
                Thread.Sleep(pause);
            }
        }

        public void ShowCountOfSteps()
        {
            Console.Write("Step: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(countOfSteps);
        }
    }
}