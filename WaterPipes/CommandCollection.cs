using System;
using WaterPipes.CommandsForGame;

namespace WaterPipes
{
    internal class CommandCollection
    {
        private ICommandForGame[] commands;

        public CommandCollection(Field inputedField, Cursor inputedCursor, IsGameHasToStart gameStartState)
        {
            commands = new ICommandForGame[]
            {
                new AddPipe(inputedField, inputedCursor),
                new AddSource(inputedField, inputedCursor),
                new ClearCell(inputedField, inputedCursor),
                new MoveCursorDown(inputedCursor),
                new MoveCursorLeft(inputedCursor),
                new MoveCursorRight(inputedCursor),
                new MoveCursorUp(inputedCursor),
                new StartGame(gameStartState)
            };
        }

        public void PerformCommands(ConsoleKey inputedKey)
        {
            foreach(ICommandForGame command in commands)
            {
                command.PerformCommand(inputedKey);
            }
        }
    }
}