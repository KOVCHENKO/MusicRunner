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

        public int scoreAward;

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

                EarnScore(scoreAward);

                Object.Destroy(this.gameObject);
            }
        }

        private void EarnScore(int amount)
        {
            Debug.Log("Earned score is: " + amount);

            if (GameManager.gm)
                GameManager.gm.AddPoints(amount);
        }
    }
}