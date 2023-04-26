using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour

{


    public bool isHit = false;

    [Header("Customizable Options")]

    public Animator anim;

    public float Health;
    public int attackDamage=10;
    public float Damage;
    public GameObject new_gameobject;

    //public ScoreNextLvl sc;
    //public NavMeshAgent nav;

    private float timer = 5f;
    private bool isDead= false;

    // Update is called once per frame
    void Update()
    {

       

        if (isHit == true)
        {
            Health = Health - Damage;
            isHit = false;

        }

        if (!isDead &&Health <= 0)
        {
            
           isDead= true;
            new_gameobject.GetComponent<NavMeshAgent>().isStopped= true;
            anim.SetBool("IsDead", true);
            ScoreNextLvl.EnemyCounter();

            timer -= Time.deltaTime;
            if (timer<0)
            {
                
                Destroy(new_gameobject);
                
            }
            //code death animation 
            //Destroy(new_gameobject);
        }

        
    }

    public void die() { 
    
    }
  
}