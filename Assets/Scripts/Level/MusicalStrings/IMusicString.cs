namespace Level.MusicalStrings
{
    public interface IMusicString
    {
        int Number{ get; }
        
        float YCoord{ get; }

        float GetEnemyNoteYCoord();

        float GetStringBreakYCoord();
    }
}