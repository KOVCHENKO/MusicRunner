using Enemy;
using Level.MusicalStrings;

namespace Level.LevelInstantiations
{
    public class LevelSevenStructure : LevelInstantiation
    {
        public override int maxLevelScore { get; set; } = 0;

        public override void CreateLevelElements()
        {
            InstantiateEnemyNotes(4, new FirstString(), enemyNote2, 2);
            InstantiateFinish();
        }
    }
}