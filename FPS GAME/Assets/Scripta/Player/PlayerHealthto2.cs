using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthto2 : MonoBehaviour
{
    public int maxHealth = 100; // Maximum amount of health the player can have
    public int currentHealth; // Current amount of health the player has

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death
        // For example, you could play a death animation or respawn the player
        SceneManager.LoadScene("Died");
        //Destroy(gameObject);
    }
}
