namespace Level.MusicalStrings
{
    public class ThirdString : IMusicString
    {
        public int Number { get; } = 3;
        public float YCoord { get; } = 1.6f;

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 0.7f;
        }
    }
}