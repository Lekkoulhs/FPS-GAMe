using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackto2 : MonoBehaviour
{
    public int damageAmount = 10; // Amount of damage to deal to player on collision
    public Animator animator; // Reference to the animator component
    private float timer = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if we collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Deal damage to the player
            PlayerHealthto2 PlayerHealthto2 = collision.gameObject.GetComponent<PlayerHealthto2>();
            PlayerHealthto2.TakeDamage(damageAmount);

            // Play the attack animation
            animator.SetTrigger("Attack");
            //animator.SetBool("IsAttacking", false);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // Check if we collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                // Deal damage to the player
                PlayerHealthto2 PlayerHealthto2 = collision.gameObject.GetComponent<PlayerHealthto2>();
                PlayerHealthto2.TakeDamage(damageAmount);

                // Play the attack animation
                animator.SetTrigger("Attack");
               //animator.SetBool("IsAttacking", false);


                timer = 2f;
            }
        }
    }
}
