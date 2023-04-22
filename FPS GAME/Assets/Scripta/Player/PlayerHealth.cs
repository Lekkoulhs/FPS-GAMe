using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHeath = 100;
    public int currHealth;
    public int damageTaken = 0;
    public Animator anim;

    private float timer = 2f;

    private void Start()
    {
        currHealth = maxHeath;
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "Enemy")
        {
            anim.SetBool("IsAttacking", true);
            TakeDamage();
        }*/

        timer = 2f;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                TakeDamage ();

                anim.SetBool("IsAttacking", true);
                 
                timer = 2f;
            }
            
        }
    }

    public void TakeDamage()
    {
        currHealth -= damageTaken;
        if (currHealth <= 0) {
            Die();
        }
    }

    public void Die()
    {
        //code what death looks like 

        Destroy(gameObject);
    }
}

