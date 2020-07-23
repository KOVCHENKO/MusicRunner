namespace Level.MusicalStrings
{
    public class FifthString : AbstractMusicString, IMusicString
    {
        public int Number { get; } = 5;
        public float YCoord { get; } = -0.4f;
        public float NotePositionYOnString { get; }
    }
}