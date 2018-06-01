using System;
using WaterPipes.CommandsForGame;
using System.Text;

namespace WaterPipes
{
    internal class CommandCollection
    {
        ICommandForGame[] Commands;

        public CommandCollection(Field inputedField, Cursor inputedCursor, IsGameHasToStart GameStartState)
        {
            Commands = new ICommandForGame[]
            {
                new AddPipe(inputedField, inputedCursor),
                new AddSource(inputedField, inputedCursor),
                new ClearCell(inputedField, inputedCursor),

                new MoveCursorDown(inputedCursor),
                new MoveCursorLeft(inputedCursor),
                new MoveCursorRight(inputedCursor),
                new MoveCursorUp(inputedCursor),

                new StartGame(GameStartState)
            };
        }

        public void PerformCommands(ConsoleKey inputedKey)
        {
            foreach(ICommandForGame command in Commands)
            {
                command.PerformCommand(inputedKey);
            }
        }
    }
}