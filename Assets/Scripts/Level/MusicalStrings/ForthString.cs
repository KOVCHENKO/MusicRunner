using UnityEngine;

namespace Level.MusicalStrings
{
    public class ForthString : IMusicString
    {
        public override int Number { get; } = 4;
        public override float YCoord { get; } = 0.6f;
    }
}