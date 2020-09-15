using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelSixteenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), pause8 },
                { new ThirdString(), pause8 },
                { new SecondString(), pause8 },
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
            
            // Another long notes
            ReduceXPosition();
            ReduceXPosition();
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            
            // Change music rythm and length
            IncreaseXPosition();
            IncreaseXPosition();
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Another strings
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            // // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new FifthString(), pause8 },
                { new ThirdString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
                { new ForthString(), pause8 },
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