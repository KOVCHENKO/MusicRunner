using System.Collections.Generic;
using System.Collections.ObjectModel;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelFiveStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), enemyNote2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(2, 4);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote2);

            CountPointsForInstantiation(2, 4);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ForthString(), enemyNote4 },
            }, enemyNote2);

            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), enemyNote2 },
                { new SecondString(), enemyNote4 },
            }, enemyNote2);

            CountPointsForInstantiation(2, 4);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), enemyNote2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ThirdString(), enemyNote2 },
                { new ForthString(), enemyNote4 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), enemyNote2 },
                { new FifthString(), enemyNote2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), enemyNote2 },
                { new FifthString(), enemyNote4 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 4);

            IncreaseXPosition();
            IncreaseXPosition();
            // Finish
            InstantiateFinish();
        }
    }
}