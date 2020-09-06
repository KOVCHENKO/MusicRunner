using UnityEngine;

namespace Level.MusicalStrings
{
    public class SecondString : IMusicString
    {
        public override string StringName { get; } = "string_2";
        public override int Number { get; } = 2;
        public override float YCoord { get; } = 2.6f;
    }
}