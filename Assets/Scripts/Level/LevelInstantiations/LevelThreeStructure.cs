using System.Collections.ObjectModel;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelThreeStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            
            
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8, 8);
            
            // Finish
            InstantiateFinish();
        }
    }
}