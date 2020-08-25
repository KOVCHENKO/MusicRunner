using System.Collections.ObjectModel;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelThreeStructure: EnemyInstantiation
    {
        public void CreateLevelElements()
        {
        
            InstantiateEnemyNotes(4, new SecondString(), pause4);
            InstantiateEnemyNotes(4, new FirstString(), pause4);
            
            
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote8);

            // Finish
            InstantiateFinish();
        }
    }
}