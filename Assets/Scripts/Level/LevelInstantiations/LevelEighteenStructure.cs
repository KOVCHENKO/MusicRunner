using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelEighteenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
             InstantiateEnemyNotes(4, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(4, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(4, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(4, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(4, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(4, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(4, new FirstString(), pause2, 2);
            
            InstantiateEnemyNotes(2, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(2, new FirstString(), pause2, 2);
            
            InstantiateEnemyNotes(1, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(1, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(1, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(1, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(1, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(1, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(1, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(1, new FirstString(), pause2, 2);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote2, 2);

            InstantiateEnemyNotes(2, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(2, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 2);
            InstantiateEnemyNotes(2, new FirstString(), pause2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 2);
            
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            
            InstantiateEnemyNotes(2, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            InstantiateEnemyNotes(2, new FifthString(), pause2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 2);
            
            IncreaseXPosition();
            IncreaseXPosition();
            
            // Finish
            InstantiateFinish();

            InstantiateFinish();
        }
    }
}