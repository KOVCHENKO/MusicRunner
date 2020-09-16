using System;
using System.Collections.Generic;
using Level.LevelInstantiations;
using Level.MusicalStrings;
using UnityEngine;
using Util;

namespace Enemy
{
    public class LevelInstantiation : MonoBehaviour
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
        private MainMenuManager mainMenuManager = MainMenuManager.mainMenuManager;

        private AudioSource _audioSource;

        // For counting max score
        public virtual int maxLevelScore { get; set; }
        public bool isForCountPointsOnly { get; set; } = false;
        // Exposed to unity editor
        public bool countOnly = false;

        void Awake()
        {
            isForCountPointsOnly = countOnly;
            _audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            int currentLevel = 0;
            if (!isForCountPointsOnly)  currentLevel = mainMenuManager.currentLevel;
            
            Debug.Log("Cur lev: " + currentLevel);

            LevelInstantiation levelStructure = null;

            switch (currentLevel)
            {
                case 1: { levelStructure = gameObject.AddComponent<LevelOneStructure>(); break; }
                case 2: { levelStructure = gameObject.AddComponent<LevelTwoStructure>(); break; }
                case 3: { levelStructure = gameObject.AddComponent<LevelThreeStructure>(); break; }
                case 4: { levelStructure = gameObject.AddComponent<LevelFourStructure>(); break; }
                case 5: { levelStructure = gameObject.AddComponent<LevelFiveStructure>(); break; }
                case 6: { levelStructure = gameObject.AddComponent<LevelSixStructure>(); break; }
                case 7: { levelStructure = gameObject.AddComponent<LevelSevenStructure>(); break; }
                case 8: { levelStructure = gameObject.AddComponent<LevelEightStructure>(); break; }
                case 9: { levelStructure = gameObject.AddComponent<LevelNineStructure>(); break; }
                case 10: { levelStructure = gameObject.AddComponent<LevelTenStructure>(); break; }
                case 11: { levelStructure = gameObject.AddComponent<LevelElevenStructure>(); break; }
                case 12: { levelStructure = gameObject.AddComponent<LevelTwelveStructure>(); break; }
                case 13: { levelStructure = gameObject.AddComponent<LevelThirteenStructure>(); break; }
                case 14: { levelStructure = gameObject.AddComponent<LevelFourteenStructure>(); break; }
                case 15: { levelStructure = gameObject.AddComponent<LevelFifteenStructure>(); break; }
                case 16: { levelStructure = gameObject.AddComponent<LevelSixteenStructure>(); break; }
                case 17: { levelStructure = gameObject.AddComponent<LevelSeventeenStructure>(); break; }
                case 18: { levelStructure = gameObject.AddComponent<LevelEighteenStructure>(); break; }
            }

            if (currentLevel != 0)
            {
                ProvideGameObjects(levelStructure);
                ProvideLevelSound(currentLevel);
            }
            if (levelStructure != null) levelStructure.CreateLevelElements();
        }

        public void InstantiateEnemyNotesOnDifferentLines(int count,
            Dictionary<IMusicString, GameObject> musicElementsOnString, GameObject enemyNoteType)
        {
            if (isForCountPointsOnly) return;
            
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

        private void MultipleInstantiationResolver(int count,
            Dictionary<IMusicString, GameObject> musicElementsOnString, float multiplicator)
        {
            for (int x = 0; x < count; x++)
            {
                foreach (var musicElementOnString in musicElementsOnString)
                {
                    Instantiate(musicElementOnString.Value,
                        new Vector3(_initialXPosition * multiplicator,
                            musicElementOnString.Key.GetEnemyNoteYCoord(musicElementOnString.Value), 0),
                        Quaternion.identity);
                }

                _initialXPosition += 1f;
            }
        }

        public void InstantiateEnemyNotes(int count, IMusicString stringNumber, GameObject enemyNoteType, int points)
        {
            if (isForCountPointsOnly)
            {
                CountPointsForInstantiation(count, points);
                return;
            }
            
            if (enemyNoteType == enemyNote8 || enemyNoteType == pause8)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f / 2);
            }
            else if (enemyNoteType == enemyNote4 || enemyNoteType == pause4)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f);
            }
            else if (enemyNoteType == enemyNote2 || enemyNoteType == pause2)
            {
                SingleInstantiationResolver(count, stringNumber, enemyNoteType, 3f * 2);
            }
        }

        public void CountPointsForInstantiation(int count, int points)
        {
            switch (points)
            {
                case 2:
                    maxLevelScore += 2 * count;
                    break;
                case 4:
                    maxLevelScore += 4 * count;
                    break;
                case 8:
                    maxLevelScore += 8 * count;
                    break;
                case 0:
                    maxLevelScore += 0;
                    break;
                default:
                    throw new Exception("Such note type is not available yet");
            }
        }

        private void SingleInstantiationResolver(int count, IMusicString stringNumber, GameObject enemyNoteType,
            float multiplier)
        {
            for (int x = 0; x < count; x++)
            {
                Instantiate(enemyNoteType,
                    new Vector3(_initialXPosition * multiplier, stringNumber.GetEnemyNoteYCoord(enemyNoteType), 0),
                    Quaternion.identity);
                _initialXPosition += 1f;
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
            if (isForCountPointsOnly) return;
            
            Instantiate(finish, new Vector3(_initialXPosition * 1.5f, finish.transform.position.y, 0), 
            Quaternion.identity);
        }

        public void ProvideLevelSound(int levelNumber)
        {
            AudioClip clip1 = (AudioClip) Resources.Load(
                LevelsPreferences.GetLevelMusicToLoad(levelNumber)
            );
            _audioSource.clip = clip1;
        }

        public void ProvideGameObjects(LevelInstantiation levelStructure)
        {
            levelStructure.enemyNote2 = enemyNote2;
            levelStructure.enemyNote4 = enemyNote4;
            levelStructure.enemyNote8 = enemyNote8;
            levelStructure.pause2 = pause2;
            levelStructure.pause4 = pause4;
            levelStructure.pause8 = pause8;
            levelStructure.finish = finish;
        }

        public virtual void CreateLevelElements()
        {
            throw new NotImplementedException("Implementation is available in LevelStructure Classes");
        }
    }
}