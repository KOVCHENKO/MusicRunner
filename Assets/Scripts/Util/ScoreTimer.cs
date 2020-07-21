namespace Util
{
    public static class ScoreTimer
    {
        public static float TargetScoreMultiplierTime = 4.0f;
        
        private static int _scoreMultiplier = 2;
        
        public static int GetScoreMultiplier()
        {
            return _scoreMultiplier;
        }

        public static void SetScoreMultiplier(int multiplier)
        {
            _scoreMultiplier *= multiplier;
        }

        public static void ResetMultiplier()
        {
            _scoreMultiplier = 2;
        }
    }
}