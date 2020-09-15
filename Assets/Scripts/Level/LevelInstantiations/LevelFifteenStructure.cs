using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelFifteenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), pause4, 0);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), pause4, 0);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FirstString(), pause4, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), pause4, 0);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), pause4, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), pause4, 0);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), pause4, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), pause4, 0);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            // Change position
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), pause8, 0);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), pause8, 0);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), pause8, 0);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), pause8, 0);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), pause8, 0);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), pause8, 0);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), pause8, 0);
            
            // Finish
            InstantiateFinish();
        }
    }
}