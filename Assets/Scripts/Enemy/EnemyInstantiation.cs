using UnityEngine;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        public GameObject enemyNote;
        public int width = 4;
        public int height = 4;
        
        private void Start()
        {
            float firstStringY = 4.3f;
            float firsrtPositionX = 0;

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; x++)
                {
                    Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, firstStringY, 0), Quaternion.identity);
                    firsrtPositionX += 1f;
                }
                
                firstStringY -= 1f;
            }
        }
    }
}