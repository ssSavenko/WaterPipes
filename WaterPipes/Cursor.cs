namespace WaterPipes
{
    internal class Cursor
    {
        private readonly int maxXCordinate;
        private readonly int maxYCordinate;

        private int xCordinate;
        private int yCordinate;

        Cursor (int xCordinateBorder, int yCordinateBorder)
        {
            maxXCordinate = xCordinateBorder;
            maxYCordinate = yCordinateBorder;

            xCordinate = 0;
            yCordinate = 0;
        }

        public int GetXCordinate {
            get
            {
                return xCordinate;
            }
            set
            {
                if (0 < value && value < maxXCordinate)
                {
                    xCordinate = value;
                }
            }
        }

        public int GetYCordinate {
            get
            {
                return yCordinate;
            }
            set
            {
                if (0 < value && value < maxYCordinate)
                {
                    yCordinate = value;
                }
            }

        }
    }
}
