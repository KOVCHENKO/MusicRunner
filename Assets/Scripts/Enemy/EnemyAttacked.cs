using UnityEngine;

namespace Enemy
{
    public class EnemyAttacked : MonoBehaviour
    {
        public GameObject explosion;
        public GameObject score;
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player")) {
                Debug.Log("Enemy note has been attacked");

                if (explosion)
                {
                    Instantiate(explosion, transform.position, transform.rotation);
                }

                if (score)
                {
                    Instantiate(score, transform.position, transform.rotation);
                }

                Object.Destroy(this.gameObject);
            }
        }
    }
}