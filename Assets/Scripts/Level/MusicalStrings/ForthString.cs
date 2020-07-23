namespace Level.MusicalStrings
{
    public class ForthString : AbstractMusicString, IMusicString
    {
        public int Number { get; } = 4;
        public float YCoord { get; } = 0.6f;
        public float NotePositionYOnString { get; } = 2.2f;
    }
}