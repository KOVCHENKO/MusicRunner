using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelElevenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
               // T
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);
            
            ReduceXPosition();
            ReduceXPosition();
            
            // Space
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            IncreaseXPosition();
            IncreaseXPosition();
            
            // H
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            ReduceXPosition();
            ReduceXPosition();
            
            // Space
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            IncreaseXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause4 },
            }, enemyNote4);

            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);

            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 8);

            IncreaseXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote8);
          
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote8);
          
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote8);
          
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            ReduceXPosition();
            ReduceXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
             CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote2);
          
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote2);
          
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote2);
          
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote2);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(1, 2);

            IncreaseXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause2 },
            }, enemyNote4);
          
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            IncreaseXPosition();
            
            InstantiateFinish();
        }
    }
}