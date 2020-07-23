namespace Level.MusicalStrings
{
    public class SecondString : AbstractMusicString, IMusicString
    {
        public int Number { get; } = 2;
        public float YCoord { get; } = 2.6f;
        public float NotePositionYOnString { get; } = 4.2f;
    }
}