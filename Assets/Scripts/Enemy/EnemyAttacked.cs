using System;
using UnityEngine;


public class EnemyAttacked : MonoBehaviour
{
    public GameObject explosion;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Enemy note has been attacked");

            if (explosion)
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }
            
            // DestroyObject(this.gameObject);
        }
    }
}