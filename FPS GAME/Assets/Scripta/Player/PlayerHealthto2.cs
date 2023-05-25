using InfimaGames.LowPolyShooterPack;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerHealthto2 : MonoBehaviour
{
    public TextMeshProUGUI Healthtext;
    public Character character;

    public int maxHealth = 100; // Maximum amount of health the player can have
    public int currentHealth; // Current amount of health the player has

   

    

    private void Start()
    {
        currentHealth = maxHealth;
        Healthtext.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Healthtext.text = currentHealth.ToString();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death
        // For example, you could play a death animation or respawn the playe
        character.cursorLocked = false;
        character.UpdateCursorState();
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Died");
        Destroy(gameObject);
    }
}
