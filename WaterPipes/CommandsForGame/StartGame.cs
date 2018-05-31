using System;
using System.Collections.Generic;
using System.Text;

namespace WaterPipes.CommandsForGame
{
    internal class StartGame : ICommandForGame
    {
        IsGameHasToStart GameState;

        public StartGame (IsGameHasToStart InputedGameState)
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
