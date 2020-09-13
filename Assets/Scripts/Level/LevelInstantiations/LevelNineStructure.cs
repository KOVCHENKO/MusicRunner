using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelNineStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);

            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(8, new FirstString(), enemyNote8, 8);
            
            InstantiateFinish();
        }
    }
}