namespace WaterPipes
{
    internal class Game
    {
        private int height;
        private int width;

        private Cursor gameCursor;
        private Field gameField;
        private IPrintableFieldWithCursor gamePrintableField;

        public Game(int inputedWidth, int inputedHeight)
        {
            height = inputedHeight;
            width = inputedWidth;

            gameCursor = new Cursor(width, height);
            gameField = new Field(height, width);
            gamePrintableField = new PrintableFieldWithCursor(gameField, gameCursor);
        }
        
        public void Run(int pause)
        {
            while
        }
    }
}
