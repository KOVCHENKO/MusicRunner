using UnityEngine;

namespace Level.MusicalStrings
{
    public class ThirdString : IMusicString
    {
        public override string StringName { get; } = "string_3";
        public override int Number { get; } = 3;
        public override float YCoord { get; } = 1.6f;
    }
}