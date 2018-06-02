using System;

namespace WaterPipes.CommandsForGame
{
    internal class StartGame : ICommandForGame
    {
        private IsGameHasToStart gameState;

        public StartGame(IsGameHasToStart InputedGameState)
        {
            gameState = InputedGameState;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Spacebar)
            {
                gameState.IsGameReady = true;
            }
        }
    }
}