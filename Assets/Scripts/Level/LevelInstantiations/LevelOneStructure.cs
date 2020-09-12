using Enemy;
using Level.MusicalStrings;

namespace Level.LevelInstantiations
{
    public class LevelOneStructure: LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            
            InstantiateEnemyNotes(1, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(1, new FirstString(), enemyNote2, 2);
            
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FirstString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new SecondString(), enemyNote2, 2);
            
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ThirdString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new FifthString(), enemyNote2, 2);
            InstantiateEnemyNotes(2, new ForthString(), enemyNote2, 2);
            
            IncreaseXPosition();
            IncreaseXPosition();
            
            // Finish
            InstantiateFinish();
        }
    }
}