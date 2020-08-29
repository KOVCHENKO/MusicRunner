using UnityEngine;

namespace Level.MusicalStrings
{
    public class ThirdString : IMusicString
    {
        public override int Number { get; } = 3;
        public override float YCoord { get; } = 1.6f;
    }
}