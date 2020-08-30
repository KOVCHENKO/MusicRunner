using UnityEngine;

namespace Level
{
    public static class LevelController
    {
        public static bool GameStarted { get; set; } = false;

        public static void BeginGame()
        {
            GameStarted = true;
        }
    }
}