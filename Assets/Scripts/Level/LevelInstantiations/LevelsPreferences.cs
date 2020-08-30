using System.Collections.Generic;

namespace Level.LevelInstantiations
{
    public static class LevelsPreferences
    {
        private static readonly Dictionary<int, int> NecessaryLevelScores;

        static LevelsPreferences()
        {
            if (NecessaryLevelScores == null)
            {
                NecessaryLevelScores = new Dictionary<int, int>();
                AddNecessaryScore(1, 0);
                AddNecessaryScore(2, 2000);
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
    }
}