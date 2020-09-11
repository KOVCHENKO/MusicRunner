using Enemy;
using Level.MusicalStrings;

namespace Level.LevelInstantiations
{
    public class LevelFourStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), pause2, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new FirstString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new SecondString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ForthString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new FifthString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ForthString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new SecondString(), pause2, 0);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new FirstString(), pause2, 0);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FirstString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ThirdString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new ForthString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), pause4, 0);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FifthString(), pause4, 0);
            
            InstantiateEnemyNotes(1, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new SecondString(), pause4, 0);
            
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ThirdString(), pause4, 0);
            
            InstantiateEnemyNotes(1, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ForthString(), pause4, 0);
            
            InstantiateEnemyNotes(1, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FifthString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FirstString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FirstString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ThirdString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ThirdString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FifthString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new FifthString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new SecondString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new SecondString(), pause4, 0);

            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ForthString(), pause4, 0);
            
            InstantiateEnemyNotes(2, new ForthString(), enemyNote4, 4);
            InstantiateEnemyNotes(1, new ForthString(), pause4, 0);

            IncreaseXPosition();
            
            // Finish
            InstantiateFinish();
        }
    }
}