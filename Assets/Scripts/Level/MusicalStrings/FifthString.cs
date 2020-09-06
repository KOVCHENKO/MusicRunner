using UnityEngine;

namespace Level.MusicalStrings
{
    public class FifthString : IMusicString
    {
        public override string StringName { get; } = "string_5";
        public override int Number { get; } = 5;
        public override float YCoord { get; } = -0.4f;
    }
}