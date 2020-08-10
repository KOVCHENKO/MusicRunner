using Level.LevelInstantiations;
using Level.MusicalStrings;
using UnityEngine;
using UnityEngine.Serialization;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        public GameObject enemyNote8;
        public GameObject enemyNote4;
        public GameObject enemyNote2;
        public GameObject finish;
        
        public int width = 4;
        public int height = 4;

        // private float _initialXPosition = 0;            

        
        private void Start()
        {
            LevelOneStructure levelOneStructure = new LevelOneStructure();
            levelOneStructure.enemyNote2 = enemyNote2;
            levelOneStructure.enemyNote4 = enemyNote4;
            levelOneStructure.enemyNote8 = enemyNote8;
            levelOneStructure.finish = finish;
            levelOneStructure.CreateLevelElements();
        }
    }
}