namespace Level.MusicalStrings
{
    public class FirstString : AbstractMusicString, IMusicString
    {
        public int Number { get; } = 1;
        public float YCoord { get; } = 3.6f;
        
        public float NotePositionYOnString { get; }
    }
}