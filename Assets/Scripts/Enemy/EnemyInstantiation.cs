using Level.LevelInstantiations;
using Level.MusicalStrings;
using UnityEditor.SceneManagement;
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
        public GameObject stringBreak;
        public float _initialXPosition = 0;


        public int levelNumber;
        
        private void Start()
        {
            // LevelOneStructure levelStructure = null;
            switch (levelNumber)
            {
                case 1:
                {
                    LevelOneStructure levelStructure = gameObject.AddComponent<LevelOneStructure>();;
                    levelStructure.enemyNote2 = enemyNote2;
                    levelStructure.enemyNote4 = enemyNote4;
                    levelStructure.enemyNote8 = enemyNote8;
                    levelStructure.finish = finish;
                    
                    levelStructure.CreateLevelElements();
                    break;
                }
                case 2:
                {
                    LevelTwoStructure levelStructure = gameObject.AddComponent<LevelTwoStructure>();;
                    levelStructure.enemyNote2 = enemyNote2;
                    levelStructure.enemyNote4 = enemyNote4;
                    levelStructure.enemyNote8 = enemyNote8;
                    levelStructure.finish = finish;
                    
                    levelStructure.CreateLevelElements();
                    break;
                }
                case 3:
                {
                    LevelThreeStructure levelStructure = gameObject.AddComponent<LevelThreeStructure>();;
                    levelStructure.enemyNote2 = enemyNote2;
                    levelStructure.enemyNote4 = enemyNote4;
                    levelStructure.enemyNote8 = enemyNote8;
                    levelStructure.stringBreak = stringBreak;
                    levelStructure.finish = finish;
                    
                    levelStructure.CreateLevelElements();
                    break;
                }
            }
            
        }
        
        public void InstantiateEnemyNotes(int count, IMusicString stringNumber, GameObject enemyNoteType)
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

        public void InstantiateStringBreak(IMusicString stringNumber)
        {
            Instantiate(stringBreak, new Vector3(_initialXPosition, stringNumber.GetStringBreakYCoord(), 0), Quaternion.identity);
        }
        
        public void InsertBlankSpace(int count, int noteType)
        {
            if (noteType == 8)
            {
                for (int x = 0; x < count; x++)
                {
                    _initialXPosition += 1f;
                }
            } else if (noteType == 4) {
                for (int x = 0; x < count; x++)
                {
                    _initialXPosition += 1f * 2;
                }    
            } else if (noteType == 2) {
                for (int x = 0; x < count; x++)
                {
                    _initialXPosition += 1f * 4;
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

        protected void InstantiateFinish()
        {
            Instantiate(finish, new Vector3(_initialXPosition * 1.5f, finish.transform.position.y, 0), Quaternion.identity);
        }
    }
}