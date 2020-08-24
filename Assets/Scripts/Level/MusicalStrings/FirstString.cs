namespace Level.MusicalStrings
{
    public class FirstString : IMusicString
    {
        public int Number { get; } = 1;
        public float YCoord { get; } = 3.6f;
        
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