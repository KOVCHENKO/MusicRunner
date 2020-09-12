using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelSixStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new ThirdString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause2 },
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause2 },
                { new FirstString(), pause2 },
                { new ThirdString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);

            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);

            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ForthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ForthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), enemyNote2 },
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(),  pause2},
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(6, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);

            CountPointsForInstantiation(6, 2);

            InstantiateEnemyNotesOnDifferentLines(6, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(6, 2);

            InstantiateEnemyNotesOnDifferentLines(6, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(6, 2);

            InstantiateEnemyNotesOnDifferentLines(6, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause2 },
                { new ThirdString(), pause2 },
                { new ForthString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(6, 2);

            IncreaseXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), enemyNote4 },
                { new ThirdString(), enemyNote2 },
            }, enemyNote4);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);

            CountPointsForInstantiation(4, 4);

            IncreaseXPosition();
            
            // Finish
            InstantiateFinish();
        }
    }
}