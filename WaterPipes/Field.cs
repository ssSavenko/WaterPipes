namespace WaterPipes
{
    internal class Field
    {
        private readonly int height;
        private readonly int width;
        public Cell[,] fieldOfCells;

        public Field(int fieldsHeigth, int fieldsWidth)
        {
            if (fieldsHeigth < 0 || fieldsWidth < 0)
            {
                throw new System.ArgumentException();
            }

            height = fieldsHeigth;
            width = fieldsWidth;
            fieldOfCells = new Cell[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    fieldOfCells[i, j] = Cell.CellIsEmpty;
                }
            }
        }

        public int Height
        {
            get{return height;}
        }

        public int Width
        {
            get { return width; }
        }

        public Cell[,] FieldOfCells
        {
            get { return fieldOfCells; }
        }

        public Cell this[int yCord , int xCord ]
        {
            get
            {
                if (yCord > height || xCord > width)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                else if (yCord < 0 || xCord < 0)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                return fieldOfCells[yCord, xCord];
            }

            set
            {
                if (yCord > height || xCord > width)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                else if (yCord < 0 || xCord < 0)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                fieldOfCells[yCord, xCord] = value;
            }
        }
    }
}
