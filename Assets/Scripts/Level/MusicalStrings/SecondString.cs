namespace Level.MusicalStrings
{
    public class SecondString : IMusicString
    {
        public int Number { get; } = 2;
        public float YCoord { get; } = 2.6f;

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 0.7f;
        }

        public float GetStringBreakYCoord()
        {
            return YCoord + 0.36f;
        }
    }
}