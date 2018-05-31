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
                    if (fieldForChanges[j, i] == Cell.CellContainsPipe)
                    {
                        bool isNearSource = (fieldForChanges[j + 1, i] == Cell.CellContainsPipeWithWater || fieldForChanges[j + 1, i] == Cell.CellContainsSource);
                        isNearSource = (fieldForChanges[j - 1, i] == Cell.CellContainsPipeWithWater || fieldForChanges[j + 1, i] == Cell.CellContainsSource) || isNearSource;
                    }
                }
            }

            return wasFieldChanged;
        }
    }
}