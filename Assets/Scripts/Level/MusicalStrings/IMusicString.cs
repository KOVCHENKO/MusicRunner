using UnityEngine;

namespace Level.MusicalStrings
{
    public interface IMusicString
    {
        int Number{ get; }
        
        float YCoord{ get; }

        float GetEnemyNoteYCoord(GameObject value);
        
        float GetEnemyNoteYCoord();

        float GetStringBreakYCoord();
    }
}