using System;
using System.Collections;

namespace Level.MusicalStrings
{
    public static class MusicStringResolver
    {
        private static readonly ArrayList MusicStrings = new ArrayList
        {
            new FirstString(),
            new SecondString(),
            new ThirdString(),
            new ForthString(),
            new FifthString()
        };
        
        public static IMusicString ResolveMusicString(int number)
        {
            foreach (IMusicString musicString in MusicStrings)
            {
                if (musicString.Number == number)
                {
                    return musicString;
                }
            }
            
            throw new Exception("There is no such music string number");
        }
    }
}