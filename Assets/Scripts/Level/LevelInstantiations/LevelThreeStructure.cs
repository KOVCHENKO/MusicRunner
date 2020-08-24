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
            InstantiateStringBreak(new FirstString());
        
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            
            InstantiateStringBreak(new FifthString());

            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            
            InstantiateStringBreak(new FirstString());
        
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            
            InstantiateStringBreak(new FifthString());

            InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            
            InstantiateStringBreak(new FirstString());
        
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            
            InstantiateStringBreak(new FifthString());

            InstantiateEnemyNotes(2, new FirstString(), enemyNote4);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            
            InstantiateStringBreak(new FifthString());

            InstantiateEnemyNotes(4, new ForthString(), enemyNote8);

            InstantiateStringBreak(new FirstString());
            
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);

            InstantiateStringBreak(new FifthString());

            InstantiateEnemyNotes(4, new ForthString(), enemyNote8);
            
            InstantiateStringBreak(new FirstString());

            // Finish
            InstantiateFinish();
        }
    }
}