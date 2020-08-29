using UnityEngine;

namespace Level.MusicalStrings
{
    public class SecondString : IMusicString
    {
        public override int Number { get; } = 2;
        public override float YCoord { get; } = 2.6f;
    }
}