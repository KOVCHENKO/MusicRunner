namespace Level.MusicalStrings
{
    public class FifthString : IMusicString
    {
        public int Number { get; } = 5;
        public float YCoord { get; } = -0.4f;

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 0.7f;
        }
    }
}