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
        public GameObject finish;
        
        public int width = 4;
        public int height = 4;

        private float _initialXPosition = 0;            

        
        private void Start()
        {
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(3, new FifthString(), enemyNote4);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);

            // Change position
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8);
            
            // Another long notes
            ReduceXPosition();
            ReduceXPosition();
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2);

            // Change music rythm and length
            IncreaseXPosition();
            IncreaseXPosition();
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8);
            
            // Finish
            Instantiate(finish, new Vector3(_initialXPosition * 1.5f, finish.transform.position.y, 0), Quaternion.identity);
        }

        private void InstantiateEnemyNotes(int count, IMusicString stringNumber, GameObject enemyNoteType)
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

        private void InstantiateEnemyOneRow(int count, IMusicString stringNumber, GameObject enemyNoteType, float xAllocation)
        {
            for (int x = 0; x < count; x++)
            {
                Instantiate(enemyNoteType, new Vector3(xAllocation, stringNumber.GetEnemyNoteYCoord(), 0), Quaternion.identity);
                _initialXPosition += 1f;
            }
        }

        private void ReduceXPosition()
        {
            _initialXPosition /= 2;
        }
        
        private void IncreaseXPosition()
        {
            _initialXPosition *= 2;
        }

    }
}