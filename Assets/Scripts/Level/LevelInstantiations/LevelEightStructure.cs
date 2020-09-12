using Enemy;
using Level.MusicalStrings;

namespace Level.LevelInstantiations
{
    public class LevelEightStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(3, new FifthString(), enemyNote4, 4);
            

            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote8, 8);
            
            // Change position
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote8, 8);
            
            // Another strings by two near 
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote8, 8);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote8, 8);
            
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
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote8, 8);
            
            // Another strings
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote8, 8);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote8, 8);
            
            // Finish
            InstantiateFinish();
        }
    }
}