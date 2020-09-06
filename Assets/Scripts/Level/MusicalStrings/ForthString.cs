using UnityEngine;

namespace Level.MusicalStrings
{
    public class ForthString : IMusicString
    {
        public override string StringName { get; } = "string_4";
        public override int Number { get; } = 4;
        public override float YCoord { get; } = 0.6f;
    }
}