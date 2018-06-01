namespace WaterPipes
{
    internal class GameIteration
    {
        private Field fieldForChanges;

        public GameIteration(Field inputedField)
        {
            fieldForChanges = inputedField;
        }

        public bool ChangeField()
        {
            Field newField = new Field(fieldForChanges.Height, fieldForChanges.Width);
            bool wasFieldChanged = false;

            for (int i =0; i < fieldForChanges.Height; i++)
            {
                for (int j = 0; j < fieldForChanges.Width; j++)
                {
                    if (fieldForChanges[i, j] == Cell.CellContainsPipe)
                    {
                        bool isNearSource = false;
                        if (i + 1 < fieldForChanges.Height)
                        {
                            isNearSource = fieldForChanges[i + 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i + 1, j] == Cell.CellContainsSource;
                        }
                        if (i > 0 && !isNearSource)
                        {
                            isNearSource = fieldForChanges[i - 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i - 1, j] == Cell.CellContainsSource;
                        }
                        if (j > 0 && !isNearSource)
                        {
                            isNearSource = fieldForChanges[i, j - 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j - 1] == Cell.CellContainsSource;
                        }
                        if (j + 1 < fieldForChanges.Width && !isNearSource)
                        {
                            isNearSource = fieldForChanges[i, j + 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j + 1] == Cell.CellContainsSource;
                        }

                        if (isNearSource)
                        {
                            newField[i, j] = Cell.CellContainsPipeWithWater;
                            wasFieldChanged = true;
                        }
                        else
                        {
                            newField[i, j] = Cell.CellContainsPipe;
                        }
                    }
                    else if (fieldForChanges[i, j] == Cell.CellContainsPipeWithWater)
                    {
                        newField[i, j] = Cell.CellContainsPipeWithWater;
                    }
                    else if (fieldForChanges[i, j] == Cell.CellContainsSource)
                    {
                        newField[i, j] = Cell.CellContainsSource;
                    }
                }
            }
            fieldForChanges.CopyFieldData(newField);
            return wasFieldChanged;
        }
    }
}