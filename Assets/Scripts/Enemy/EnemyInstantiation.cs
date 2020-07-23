using UnityEngine;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        public GameObject enemyNote;
        public int width = 2;
        public int height = 2;
        
        private void Start()
        {
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    Instantiate(enemyNote, new Vector3(x, y, 0), Quaternion.identity);
                }
            } 
        }
    }
}