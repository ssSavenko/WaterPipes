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
                        if (!WasPastStringChanged[j])
                        {
                            WasPastStringChanged[j] = false;
                            WasPastCellChanged = false;

                            if (i < fieldForChanges.Width - 1)
                            {
                                if (fieldForChanges[i + 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i + 1, j] == Cell.CellContainsSource)
                                {
                                    fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                    WasPastStringChanged[j] = true;
                                    WasPastCellChanged = true;
                                    IsFieldWereChanged = true;
                                }
                            }

                            if (i != fieldForChanges.Height && i > 0)
                            {
                                if (!WasPastStringChanged[j])
                                {
                                    if (fieldForChanges[i - 1, j] == Cell.CellContainsPipeWithWater || fieldForChanges[i - 1, j] == Cell.CellContainsSource)
                                    {
                                        fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                        WasPastStringChanged[j] = true;
                                        WasPastCellChanged = true;
                                        IsFieldWereChanged = true;
                                    }
                                }
                            }
                        }

                        if (!WasPastCellChanged && fieldForChanges[i, j] != Cell.CellContainsPipeWithWater)
                        {
                            WasPastCellChanged = false;
                            if (j != fieldForChanges.Width && j > 0)
                            {
                                if (!WasPastStringChanged[j])
                                {
                                    if (fieldForChanges[i, j - 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j - 1] == Cell.CellContainsSource)
                                    {
                                        fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                        WasPastStringChanged[j] = true;
                                        WasPastCellChanged = true;
                                        IsFieldWereChanged = true;
                                    }
                                }
                            }
                            if (j < fieldForChanges.Height - 1)
                            {
                                if (fieldForChanges[i, j + 1] == Cell.CellContainsPipeWithWater || fieldForChanges[i, j + 1] == Cell.CellContainsSource)
                                {
                                    fieldForChanges[i, j] = Cell.CellContainsPipeWithWater;
                                    WasPastStringChanged[j] = true;
                                    WasPastCellChanged = true;
                                    IsFieldWereChanged = true;
                                }
                            }
                        }

                        if (fieldForChanges[i, j] == Cell.CellIsEmpty)
                        {
                            WasPastStringChanged[j] = false;
                            WasPastCellChanged = false;
                        }
                    }
                }
                WasPastCellChanged = false;
            }
            return IsFieldWereChanged;
        }
    }
}