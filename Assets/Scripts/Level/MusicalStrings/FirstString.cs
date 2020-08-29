using UnityEngine;

namespace Level.MusicalStrings
{
    public class FirstString : IMusicString
    {
        public override int Number { get; } = 1;
        public override float YCoord { get; } = 3.6f;
    }
}