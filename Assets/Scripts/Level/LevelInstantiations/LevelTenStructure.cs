using System.Collections.Generic;
using Enemy;
using Level.MusicalStrings;
using UnityEngine;

namespace Level.LevelInstantiations
{
    public class LevelTenStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FifthString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new SecondString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new ForthString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), pause2 },
                { new ThirdString(), enemyNote2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new SecondString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote2 },
                { new ThirdString(), pause2 },
                { new FifthString(), pause2 },
            }, enemyNote2);
            
            CountPointsForInstantiation(4, 2);

            IncreaseXPosition();
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), enemyNote4 },
                { new ThirdString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), pause4 },
                { new ForthString(), enemyNote4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), pause4 },
                { new ForthString(), pause4 },
                { new FifthString(), enemyNote4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), pause4 },
                { new ForthString(), enemyNote4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), pause4 },
                { new ThirdString(), enemyNote4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause4 },
                { new SecondString(), enemyNote4 },
                { new ThirdString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
          
            CountPointsForInstantiation(2, 4);

            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote4 },
                { new ThirdString(), pause4 },
                { new FifthString(), pause4 },
            }, enemyNote4);
            
            CountPointsForInstantiation(2, 4);

            IncreaseXPosition();
            
            // Eight note
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
           
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            CountPointsForInstantiation(4, 8);

            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(4, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Enemy Note 8 - 2 pieces
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(2, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            // Eight note - 1 piece
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
              InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
              InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), pause8 },
                { new FifthString(), enemyNote8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), pause8 },
                { new ForthString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), pause8 },
                { new ThirdString(), enemyNote8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), pause8 },
                { new SecondString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotesOnDifferentLines(1, new Dictionary<IMusicString, GameObject>()
            {
                { new FirstString(), enemyNote8 },
                { new ThirdString(), pause8 },
                { new FifthString(), pause8 },
            }, enemyNote8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);

            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(8, new FirstString(), enemyNote8, 8);
            
            InstantiateFinish();
        }
    }
}