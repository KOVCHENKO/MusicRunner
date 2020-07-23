namespace Level.MusicalStrings
{
    public abstract class AbstractMusicString
    {
        protected float YCoord;

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 1.2f;
        }

        public float GetDifferenceBetweenNotes()
        {
            return 5f;
        }
    }
}