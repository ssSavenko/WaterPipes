namespace WaterPipes
{
    class CursorForField : ICursor
    {
        private readonly int maxXCord;
        private readonly int maxYCord;
        private int xCord;
        private int yCord;

        public CursorForField (int height, int width)
        {
            xCord = 0;
            yCord = 0;
            maxXCord = width;
            maxYCord = height;
        }

        public int GetY {
            get { return yCord; }
        }

        public int GetX {
            get { return xCord; }
        }

        public void MoveCursorLeft()
        {
            if (xCord - 1 >= 0)
            {
                xCord--;
            }
        }

        public void MoveCursorLower()
        {
            if (yCord + 1 < maxYCord)
            {
                yCord++;
            }
        }

        public void MoveCursorRight()
        {
            if (xCord + 1 < maxXCord)
            {
                xCord++;
            }
        }

        public void MoveCursorUpper()
        {
            if (yCord - 1 >= 0)
            {
                yCord--;
            }
        }
    }
}
