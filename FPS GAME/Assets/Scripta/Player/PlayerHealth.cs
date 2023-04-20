using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
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
        Debug.Log("Player has died!");
        // Restart the level or show a game over screen.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                TakeDamage(enemy.attackDamage);
                Debug.Log("Player has taken " + enemy.Damage + " damage from a zombie!");
            }
        }
    }
}

