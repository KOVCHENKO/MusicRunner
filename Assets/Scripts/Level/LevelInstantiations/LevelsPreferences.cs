using System.Collections.Generic;
using UnityEngine;
using Util;

namespace Level.LevelInstantiations
{
    public static class LevelsPreferences
    {
        public static Dictionary<int, int> NecessaryLevelScores { get; }
        private static int EarnedLevelScores;

        static LevelsPreferences()
        {
            if (NecessaryLevelScores == null)
            {
                NecessaryLevelScores = new Dictionary<int, int>();
                AddNecessaryScore(1, -1);
                AddNecessaryScore(2, -1);
                AddNecessaryScore(3, 3000);
                AddNecessaryScore(4, 4000);
                AddNecessaryScore(5, 5000);
                AddNecessaryScore(6, 6000);
            }
        }

        private static void AddNecessaryScore(int key, int value)
        {
            if (!NecessaryLevelScores.ContainsKey(key))
            {
                NecessaryLevelScores.Add(key, value);
            }
        }
        
        public static int GetLevelScoresToLoad(int levelNumber)
        {
            return NecessaryLevelScores[levelNumber];
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
    }
}