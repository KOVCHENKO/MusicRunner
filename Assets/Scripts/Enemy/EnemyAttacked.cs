using System;
using UnityEngine;
using UnityEngine.Serialization;
using Util;
using Object = UnityEngine.Object;

namespace Enemy
{
    public class EnemyAttacked : MonoBehaviour
    {
        public GameObject explosion;
        public GameObject scoreTwo;
        public GameObject scoreFour;
        public GameObject scoreEight;

        private void Update()
        {
            ScoreTimer.TargetScoreMultiplierTime -= Time.deltaTime;
        }

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
            // Set Score Multiplier based on Timer
            if (ScoreTimer.TargetScoreMultiplierTime <= 0)
            {
                Debug.Log("Resetting multiplier: " + ScoreTimer.TargetScoreMultiplierTime);
                
                ScoreTimer.TargetScoreMultiplierTime = 0;
                ScoreTimer.TargetScoreMultiplierTime += 4.0f;
                ScoreTimer.ResetMultiplier();
            }
            else
            {
                Debug.Log("Multiplying multiplier: " + ScoreTimer.TargetScoreMultiplierTime);
                ScoreTimer.SetScoreMultiplier(2);
            }

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