using System.Collections.Generic;
using Enemy;
using UnityEngine;
using Util;

namespace Level.LevelInstantiations
{
    public static class LevelsPreferences
    {
        public static Dictionary<int, int> NecessaryLevelScores { get; }
        public static Dictionary<int, string> LevelMusic { get; }
        private static int EarnedLevelScores;

        static LevelsPreferences()
        {
            if (NecessaryLevelScores == null)
            {
                NecessaryLevelScores = new Dictionary<int, int>();
                if (!NecessaryLevelScores.ContainsKey(1)) { NecessaryLevelScores.Add(1, -1); }
                AddNecessaryScore(2);
                AddNecessaryScore(3);
                AddNecessaryScore(4);
                AddNecessaryScore(5);
                AddNecessaryScore(6);
                AddNecessaryScore(7);
                AddNecessaryScore(8);
                AddNecessaryScore(9);
                AddNecessaryScore(10);
                AddNecessaryScore(11);
                AddNecessaryScore(12);
                AddNecessaryScore(13);
                AddNecessaryScore(14);
                AddNecessaryScore(15);
                AddNecessaryScore(16);
                AddNecessaryScore(17);
                AddNecessaryScore(18);
            }
            
            if (LevelMusic == null)
            {
                LevelMusic = new Dictionary<int, string>();
                AddLevelMusic(1);
                AddLevelMusic(2);
                AddLevelMusic(3);
                AddLevelMusic(4);
                AddLevelMusic(5);
                AddLevelMusic(3);
                
                AddLevelMusic(1);
                AddLevelMusic(2);
                AddLevelMusic(3);
                AddLevelMusic(4);
                AddLevelMusic(5);
                AddLevelMusic(3);
                
                AddLevelMusic(1);
                AddLevelMusic(2);
                AddLevelMusic(3);
                AddLevelMusic(4);
                AddLevelMusic(5);
                AddLevelMusic(3);
            }
        }

        private static void AddNecessaryScore(int key)
        {
            if (!NecessaryLevelScores.ContainsKey(key))
            {
                // Calculate necessary score
                int scoresRemainToLoad = 0;
                Dictionary<int, LevelInstantiation> allAvailableLevelInstances = GetAllAvailableLevelInstances();
                for (int i = 1; i < key; i++)
                {
                    int maxLevelScore = 0;
                    
                    allAvailableLevelInstances[i].isForCountPointsOnly = true;
                    allAvailableLevelInstances[i].CreateLevelElements();
                    maxLevelScore = allAvailableLevelInstances[i].maxLevelScore;
                    Debug.Log("Max level score for level: " + allAvailableLevelInstances[i] + "is: " + maxLevelScore);
                    
                    scoresRemainToLoad += maxLevelScore;
                }
                
                // Decrease by 10%
                scoresRemainToLoad -= scoresRemainToLoad / 10;
                Debug.Log("Score remain to load for level: " + key + " is: " + scoresRemainToLoad);
                
                NecessaryLevelScores.Add(key, scoresRemainToLoad);
            }
        }

        private static void AddLevelMusic(int trackNumber)
        {
            if (!LevelMusic.ContainsKey(trackNumber))
            {
                LevelMusic.Add(trackNumber, "Music/Track" + trackNumber);
            }
        }
        
        public static int GetLevelScoresToLoad(int levelNumber)
        {
            return NecessaryLevelScores[levelNumber];
        }
        
        public static string GetLevelMusicToLoad(int trackNumber)
        {
            return LevelMusic[trackNumber];
        }

        public static int GetEarnedLevelScores()
        {
            EarnedLevelScores = 0;
            
            for (int i = 1; i <= 6; i++)
            {
                Debug.Log("Level : " + 1 + ": " + PlayerPrefs.GetInt("l" + i));
                EarnedLevelScores += PlayerPrefManager.GetScore(i);
            }

            Debug.Log("Earner level score: " + EarnedLevelScores);
            
            return EarnedLevelScores;
        }
        
        
        public static Dictionary<int, LevelInstantiation> GetAllAvailableLevelInstances()
        {
            GameObject gameObject = new GameObject();
            Dictionary<int, LevelInstantiation> allAvailableLevelInstances = new Dictionary<int, LevelInstantiation>();
            allAvailableLevelInstances.Add(1, gameObject.AddComponent<LevelOneStructure>());
            allAvailableLevelInstances.Add(2, gameObject.AddComponent<LevelTwoStructure>());
            allAvailableLevelInstances.Add(3, gameObject.AddComponent<LevelThreeStructure>());
            allAvailableLevelInstances.Add(4, gameObject.AddComponent<LevelFourStructure>());
            allAvailableLevelInstances.Add(5, gameObject.AddComponent<LevelFiveStructure>());
            allAvailableLevelInstances.Add(6, gameObject.AddComponent<LevelSixStructure>());
            allAvailableLevelInstances.Add(7, gameObject.AddComponent<LevelSevenStructure>());
            allAvailableLevelInstances.Add(8, gameObject.AddComponent<LevelEightStructure>());
            allAvailableLevelInstances.Add(9, gameObject.AddComponent<LevelNineStructure>());
            allAvailableLevelInstances.Add(10, gameObject.AddComponent<LevelTenStructure>());
            allAvailableLevelInstances.Add(11, gameObject.AddComponent<LevelElevenStructure>());
            allAvailableLevelInstances.Add(12, gameObject.AddComponent<LevelTwelveStructure>());
            allAvailableLevelInstances.Add(13, gameObject.AddComponent<LevelThirteenStructure>());
            allAvailableLevelInstances.Add(14, gameObject.AddComponent<LevelFourteenStructure>());
            allAvailableLevelInstances.Add(15, gameObject.AddComponent<LevelFifteenStructure>());
            allAvailableLevelInstances.Add(16, gameObject.AddComponent<LevelSixteenStructure>());
            allAvailableLevelInstances.Add(17, gameObject.AddComponent<LevelSeventeenStructure>());
            allAvailableLevelInstances.Add(18, gameObject.AddComponent<LevelEighteenStructure>());
        
            return allAvailableLevelInstances;
        }
    }
}