using UnityEngine;

namespace Level.MusicalStrings
{
    public class ThirdString : IMusicString
    {
        public int Number { get; } = 3;
        public float YCoord { get; } = 1.6f;

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