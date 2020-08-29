using UnityEngine;

namespace Level.MusicalStrings
{
    public class ForthString : IMusicString
    {
        public int Number { get; } = 4;
        public float YCoord { get; } = 0.6f;

        public float GetEnemyNoteYCoord(GameObject value)
        {
            if (value.CompareTag("Note"))
            {    
                return YCoord + 0.7f;
            }

            return YCoord;
        }

        public float GetEnemyNoteYCoord()
        {
            return YCoord + 0.7f;
        }

        public float GetStringBreakYCoord()
        {
            return YCoord + 0.36f;
        }
    }
}