using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelThirteenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat pattern
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote4);
             
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote4);
             
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
           
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            // Repeat pattern reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            // Repeat pattern picture
            
              InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat pattern
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
           
            CountPointsForInstantiation(1, 4);

            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            // Repeat pattern reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            IncreaseXPosition();
            
            // Remake pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause8 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new FifthString(), pause8 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 2);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Remake pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote2 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 2);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
           
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Repeat pattern reverse
           
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ThirdString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateFinish();
        }
    }
}