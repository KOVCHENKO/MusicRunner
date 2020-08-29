using System.Collections.Generic;
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
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new ThirdString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ForthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ForthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            IncreaseXPosition();
            IncreaseXPosition();
            //
            // InstantiateEnemyNotes(4, new SecondString(), pause4);
            // InstantiateEnemyNotes(4, new FirstString(), pause4);
            //
            // InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            // InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            // InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            // InstantiateEnemyNotes(4, new FirstString(), enemyNote4);
            // InstantiateEnemyNotes(4, new SecondString(), enemyNote4);
            // InstantiateEnemyNotes(2, new FirstString(), enemyNote4);
            //
            IncreaseXPosition();
            //
            // InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            // InstantiateEnemyNotes(4, new ForthString(), enemyNote8);
            // InstantiateEnemyNotes(4, new ThirdString(), enemyNote8);
            // InstantiateEnemyNotes(4, new ForthString(), enemyNote8);

            
            // Instantiate notes on several strings
            // InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            // {
            //     { new SecondString(), enemyNote4 },
            //     { new ThirdString(), enemyNote4 },
            //     { new FirstString(), pause4 },
            //     { new FifthString(), pause4 },
            // }, enemyNote4);
            
         
            // Finish
            InstantiateFinish();
        }
    }
}