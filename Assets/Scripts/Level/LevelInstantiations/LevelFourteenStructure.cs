using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelFourteenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Repeat stairs reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Repeat stairs reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            IncreaseXPosition();
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat stairs pattern
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);

            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);
            
            // Stairs pattern reverse repeat
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {    
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);
            
            ReduceXPosition();
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Repeat stairs reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Repeat stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Repeat stairs reverse
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote4);
            
            IncreaseXPosition();
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);
            
            // Repeat stairs pattern
            
            // Stairs pattern 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 4);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
            }, enemyNote8);

            // Stairs pattern reverse 
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);
            
            // Stairs pattern reverse repeat
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {    
                { new FirstString(), pause8 },
                { new ThirdString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ForthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);

            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(1, 8);
            
            InstantiateFinish();
        }
    }
}