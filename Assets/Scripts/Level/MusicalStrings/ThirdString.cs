namespace Level.MusicalStrings
{
    public class ThirdString : AbstractMusicString, IMusicString
    {
        public int Number { get; } = 3;
        public float YCoord { get; } = 1.6f;
        public float NotePositionYOnString { get; } = 3.2f;
    }
}