using System;

namespace WaterPipes.CommandsForGame
{
    internal class StartGame : ICommandForGame
    {
        private IsGameHasToStart GameState;

        public StartGame(IsGameHasToStart InputedGameState)
        {
            GameState = InputedGameState;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Spacebar)
            {
                GameState.IsGameReady = true;
            }
        }
    }
}