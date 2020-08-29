using System.Collections.Generic;
using Level.LevelInstantiations;
using Level.MusicalStrings;
using UnityEngine;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        // Scores +
        public GameObject enemyNote8;
        public GameObject enemyNote4;
        public GameObject enemyNote2;

        // Scores -
        public GameObject pause2;
        public GameObject pause4;
        public GameObject pause8;

        public GameObject finish;
        public float _initialXPosition = 0;


        public int levelNumber;

        private void Start()
        {
            switch (levelNumber)
            {
                case 1:
                {
                    LevelOneStructure levelStructure = gameObject.AddComponent<LevelOneStructure>();
                    ProvideGameObjects(levelStructure);
                    levelStructure.CreateLevelElements();
                    break;
                }
                case 2:
                {
                    LevelTwoStructure levelStructure = gameObject.AddComponent<LevelTwoStructure>();
                    ProvideGameObjects(levelStructure);
                    levelStructure.CreateLevelElements();
                    break;
                }
                case 3:
                {
                    LevelThreeStructure levelStructure = gameObject.AddComponent<LevelThreeStructure>();
                    ProvideGameObjects(levelStructure);
                    levelStructure.CreateLevelElements();
                    break;
                }
            }

        }

        // TODO: Transfer to separate classes
        public void InstantiateEnemyNotesOnDifferentLines(int count,
            Dictionary<IMusicString, GameObject> musicElementsOnString, GameObject enemyNoteType)
        {
            if (enemyNoteType == enemyNote8 || enemyNoteType == pause8)
            {
                MultipleInstantiationResolver(count, musicElementsOnString, 3f / 2);
            }
            else if (enemyNoteType == enemyNote4 || enemyNoteType == pause4)
            {
                MultipleInstantiationResolver(count, musicElementsOnString, 3f);
            }
            else if (enemyNoteType == enemyNote2 || enemyNoteType == pause2)
            {
                MultipleInstantiationResolver(count, musicElementsOnString, 3f * 2);
            }
        }

        private void MultipleInstantiationResolver(int count, Dictionary<IMusicString, GameObject> musicElementsOnString, float multiplicator)
        {
            for (int x = 0; x < count; x++)
            {
                foreach (var musicElementOnString in musicElementsOnString)
                {
                    Instantiate(musicElementOnString.Value,
                        new Vector3(_initialXPosition * multiplicator, musicElementOnString.Key.GetEnemyNoteYCoord(musicElementOnString.Value), 0),
                        Quaternion.identity);
                }

                _initialXPosition += 1f;
            }
        }

        public void InstantiateEnemyNotes(int count, IMusicString stringNumber, GameObject enemyNoteType)
        {
            if (enemyNoteType == enemyNote8 || enemyNoteType == pause8)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f / 2);
            } else if (enemyNoteType == enemyNote4 || enemyNoteType == pause4)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f);
            }
            else if (enemyNoteType == enemyNote2 || enemyNoteType == pause2)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f * 2);
            }
        }

        private void SingleInstantiationResolver(int count, IMusicString stringNumber, GameObject enemyNoteType, float multiplier)
        {
            for (int x = 0; x < count; x++)
            {
                Instantiate(enemyNoteType, new Vector3(_initialXPosition * multiplier, stringNumber.GetEnemyNoteYCoord(enemyNoteType), 0), Quaternion.identity);
                _initialXPosition += 1f;
            }
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

        public void ProvideGameObjects(EnemyInstantiation levelStructure)
        {
            levelStructure.enemyNote2 = enemyNote2;
            levelStructure.enemyNote4 = enemyNote4;
            levelStructure.enemyNote8 = enemyNote8;
            levelStructure.pause2 = pause2;
            levelStructure.pause4 = pause4;
            levelStructure.pause8 = pause8;
            levelStructure.finish = finish;
        }
        
    }
}