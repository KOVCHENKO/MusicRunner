using Level.MusicalStrings;
using UnityEngine;
using UnityEngine.Serialization;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        public GameObject enemyNote8;
        public GameObject enemyNote4;
        public GameObject enemyNote2;
        
        public int width = 4;
        public int height = 4;

        private float _initialXPosition = 0;            

        
        private void Start()
        {
            InstantiateEnemyNotes(4, new FirstString());
            InstantiateEnemyNotes(4, new ThirdString());
            InstantiateEnemyNotes(4, new SecondString());
        }

        private void InstantiateEnemyNotes(int count, IMusicString stringNumber)
        {
            for (int x = 0; x < count; x++)
            {
                Instantiate(enemyNote8, new Vector3(_initialXPosition * 3f, stringNumber.GetEnemyNoteYCoord(), 0), Quaternion.identity);
                _initialXPosition += 1f;
            }
        }
        
        
    }
}