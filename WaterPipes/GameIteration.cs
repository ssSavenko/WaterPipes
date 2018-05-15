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
            bool IsFieldWereChanged = false;
            bool[] WasPastStringChanged = new bool[fieldForChanges.Width];
            bool WasPastCellChanged = false;

            for (int i = 0; i < fieldForChanges.Height; i++)
            {
                for (int j = 0; j < fieldForChanges.Width; j++)
                {
                    if (fieldForChanges[i, j] == Cell.CellContainsPipe)
                    {
                        if (i > 0)
                        {
                            if (!WasPastStringChanged[j])
                            {
                                if (fieldForChanges[i - 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i - 1, j] == Cell.CellContainsSource)
                                {
                                    fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                    WasPastStringChanged[j] = true;
                                    IsFieldWereChanged = true;
                                }
                                else
                                {
                                    WasPastStringChanged[j] = false;
                                }
                            }
                            else
                            {
                                WasPastStringChanged[j] = false;
                            }
                        }
                        else if (j > 0)
                        {
                            if (!WasPastCellChanged)
                            {
                                if (fieldForChanges[i, j - 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j - 1] == Cell.CellContainsSource)
                                {
                                    fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                    WasPastCellChanged = true;
                                    IsFieldWereChanged = true;
                                }
                                else
                                {
                                    WasPastCellChanged = false;
                                }
                            }
                        }
                        else if (i < fieldForChanges.Height)
                        {
                            if (fieldForChanges[i + 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i + 1, j] == Cell.CellContainsSource)
                            {
                                fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                WasPastStringChanged[j] = true;
                                IsFieldWereChanged = true;
                            }
                            else
                            {
                                WasPastStringChanged[j] = false;
                            }
                        }
                        else if (j < fieldForChanges.Width)
                        {
                            if (fieldForChanges[i, j + 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j + 1] == Cell.CellContainsSource)
                            {
                                fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                WasPastCellChanged = true;
                                IsFieldWereChanged = true;
                            }
                            else
                            {
                                WasPastCellChanged = false;
                            }
                        }
                    }
                }
                WasPastCellChanged = false;
            }
            return IsFieldWereChanged;
        }
    }
}