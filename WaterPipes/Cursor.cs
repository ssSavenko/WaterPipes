namespace WaterPipes
{
    internal class Cursor
    {
        private readonly int maxXCordinate;
        private readonly int maxYCordinate;

        private int xCordinate;
        private int yCordinate;

        public Cursor(int xCordinateBorder, int yCordinateBorder)
        {
            maxXCordinate = xCordinateBorder;
            maxYCordinate = yCordinateBorder;

            xCordinate = 0;
            yCordinate = 0;
        }

        public int XCordinate
        {
            get { return xCordinate; }
            set
            {
                if (0 <= value && value < maxXCordinate)
                {
                    xCordinate = value;
                }
            }
        }

        public int YCordinate
        {
            get { return yCordinate; }
            set
            {
                if (0 <= value && value < maxYCordinate)
                {
                    yCordinate = value;
                }
            }
        }
    }
}