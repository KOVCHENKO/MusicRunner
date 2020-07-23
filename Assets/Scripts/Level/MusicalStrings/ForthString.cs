namespace Level.MusicalStrings
{
    public class ForthString : IMusicString
    {
        public int Number { get; } = 4;
        public float YCoord { get; } = 0.6f;

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 0.7f;
        }
    }
}