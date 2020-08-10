using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public abstract class LevelInstantiationUtils : MonoBehaviour
    {
        public GameObject enemyNote8;
        public GameObject enemyNote4;
        public GameObject enemyNote2;
        public GameObject finish;
        
        protected float _initialXPosition = 0;

        protected void InstantiateEnemyNotes(int count, IMusicString stringNumber, GameObject enemyNoteType)
        {
            if (enemyNoteType == enemyNote8)
            {
                for (int x = 0; x < count; x++)
                {
                    Instantiate(enemyNoteType, new Vector3(_initialXPosition * 3f / 2, stringNumber.GetEnemyNoteYCoord(), 0), Quaternion.identity);
                    _initialXPosition += 1f;
                }
            } else if (enemyNoteType == enemyNote4)
            {
                for (int x = 0; x < count; x++)
                {
                    Instantiate(enemyNoteType, new Vector3(_initialXPosition * 3f, stringNumber.GetEnemyNoteYCoord(), 0), Quaternion.identity);
                    _initialXPosition += 1f;
                }
            }
            else if (enemyNoteType == enemyNote2)
            {
                for (int x = 0; x < count; x++)
                {
                    Instantiate(enemyNoteType, new Vector3(_initialXPosition * 3f * 2, stringNumber.GetEnemyNoteYCoord(), 0), Quaternion.identity);
                    _initialXPosition += 1f;
                }
            }
        }
        
        protected void IncreaseXPosition()
        {
            _initialXPosition *= 2;
        }
        
        protected void ReduceXPosition()
        {
            _initialXPosition /= 2;
        }
    }
}