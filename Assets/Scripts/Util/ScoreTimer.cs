namespace Util
{
    public static class ScoreTimer
    {
        private static int _scoreMultiplier;
        
        public static int GetScoreMultiplier()
        {
            return _scoreMultiplier;
        }

        public static void SetScoreMultiplier(int multiplier)
        {
            _scoreMultiplier += multiplier;
        }
    }
}