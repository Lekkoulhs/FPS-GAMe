using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour

{


    public bool isHit = false;

    [Header("Customizable Options")]

    public Animator anim;

    public float Health;
    public int attackDamage=10;
    public float Damage;
    public GameObject new_gameobject;
    //public NavMeshAgent nav;

    private float timer = 5f;

    // Update is called once per frame
    void Update()
    {
        if (isHit == true)
        {
            Health = Health - Damage;
            isHit = false;

        }

        if (Health <= 0)
        {
            new_gameobject.GetComponent<NavMeshAgent>().isStopped= true;
            anim.SetBool("IsDead", true);
            timer -= Time.deltaTime;
            if (timer<0)
            {
                Destroy(new_gameobject);
            }
            //code death animation 
            //Destroy(new_gameobject);
        }
    }
}