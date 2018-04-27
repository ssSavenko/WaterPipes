namespace WaterPipes
{
    interface ICursor
    {
        int GetY { get; }
        int GetX { get; }

        void MoveCursorLeft();
        void MoveCursorLower();
        void MoveCursorRight();
        void MoveCursorUpper();
    }
}
