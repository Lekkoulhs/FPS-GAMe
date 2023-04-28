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
   //   public Character character;

    public float Health;
    public int attackDamage=10;
    public float Damage;
    public GameObject Enemyz;

    //public NavMeshAgent nav;

    public float timer = 5f;
    public bool isDead= false;

    // Update is called once per frame
    void Update()
    {

        if (isHit == true)
        {
            Health = Health - Damage;
            isHit = false;

        }

        if (isDead == false && Health <= 0)
        {

            die();
            
            

        }
        if (isDead == true)
        {
            despawn();
        }
        
    }

    public void die() 
    {
         
        
        Enemyz.GetComponent<NavMeshAgent>().isStopped = true;
        anim.SetBool("IsDead", true);
        setRigidbodyState(true);
        setColliderState(false);
        ScoreNextLvl.EnemyCounter();
        isDead = true;
       


    }
    public void despawn()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            Destroy(Enemyz);

        }

    }
  
    
    void setRigidbodyState(bool state)
    {

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;

    }


    void setColliderState(bool state)
    {

        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }

        GetComponent<Collider>().enabled = !state;

    }
    
}