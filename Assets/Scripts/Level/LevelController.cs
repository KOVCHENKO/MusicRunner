using UnityEngine;

namespace Level
{
    public static class LevelController
    {
        public static bool GameStarted { get; private set; } = false;

        public static void BeginGame()
        {
            GameStarted = true;
        }
    }
}