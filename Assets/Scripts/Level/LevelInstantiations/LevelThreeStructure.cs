using System.Collections.ObjectModel;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelThreeStructure: LevelInstantiation
    {
        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4);

            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4);
       
            IncreaseXPosition();
            
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            
            
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new SecondString(), enemyNote8);
            InstantiateEnemyNotes(8, new FifthString(), enemyNote8);
            InstantiateEnemyNotes(8, new ForthString(), enemyNote8);
            
            // Finish
            InstantiateFinish();
        }
    }
}