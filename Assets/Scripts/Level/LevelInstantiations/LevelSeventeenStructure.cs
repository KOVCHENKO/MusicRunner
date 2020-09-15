using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelSeventeenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Eight notes
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
             InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Eight notes
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
             InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Eight notes
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(2, 8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
                { new FirstString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateFinish();
        }
    }
}