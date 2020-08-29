using UnityEngine;

namespace Level.MusicalStrings
{
    public abstract class IMusicString
    {
        public abstract int Number { get; }
        
        public abstract float YCoord{ get; }

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
            throw new System.NotImplementedException();
        }

        public float GetStringBreakYCoord()
        {
            return YCoord + 0.36f;
        }
    }
}