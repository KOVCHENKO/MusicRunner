using Enemy;
using Level.MusicalStrings;

namespace Level.LevelInstantiations
{
    public class LevelTwoStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            ReduceXPosition();

            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            
            IncreaseXPosition();

            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote4, 4);
        
            ReduceXPosition();

            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            
            IncreaseXPosition();
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote4, 4);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote4, 4);
            
            InstantiateEnemyNotes(4, new FirstString(), enemyNote4, 4);

            IncreaseXPosition();
            
            // Finish
            InstantiateFinish();
        }
    }
}