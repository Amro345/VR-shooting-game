using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100; // The enemy's starting health

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player has touched the enemy
        {
            health -= 10; // Reduce the enemy's health by 10
            if (health <= 0) // Check if the enemy is dead
            {
                Die(); // Call the Die() function to destroy the enemy
            }
        }
    }

    void Die()
    {
        // Play a death animation or sound effect
        Destroy(gameObject); // Destroy the enemy GameObject
    }
}
