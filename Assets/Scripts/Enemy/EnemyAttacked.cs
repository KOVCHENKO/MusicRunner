using UnityEngine;
using Util;

namespace Enemy
{
    public class EnemyAttacked : MonoBehaviour
    {
        public GameObject explosion;
        public GameObject scoreTwo;
        public GameObject scoreFour;
        public GameObject scoreEight;
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player")) {
                Debug.Log("Enemy note has been attacked");

                if (explosion)
                {
                    Instantiate(explosion, transform.position, transform.rotation);
                }

                DefineEarnedScore();

                Object.Destroy(this.gameObject);
            }
        }

        private void DefineEarnedScore()
        {
            ScoreTimer.SetScoreMultiplier(2);

            switch (ScoreTimer.GetScoreMultiplier())
            {
                case 2: 
                    Instantiate(scoreTwo, transform.position, transform.rotation);
                    break;
                case 4:
                    Instantiate(scoreFour, transform.position, transform.rotation);
                    break;
                case 8:
                    Instantiate(scoreEight, transform.position, transform.rotation);
                    break;
                default:
                    Instantiate(scoreEight, transform.position, transform.rotation);
                    break;
            }
        }
    }
}