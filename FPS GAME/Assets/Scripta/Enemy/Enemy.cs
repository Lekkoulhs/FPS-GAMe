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

    public int enemieskilled = 0;
    public int enemiestokill = 2;
    //public NavMeshAgent nav;

   
    private void Start()
    {
        //ScoreNextLvl S = gameObject.GetComponent<ScoreNextLvl>();

    }

    private float timer = 5f;

    // Update is called once per frame
    void Update()
    {

        if (enemieskilled >= enemiestokill)
        {
            ChangeScene();
        }

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
                enemieskilled++;
                Destroy(new_gameobject);
                
            }
            //code death animation 
            //Destroy(new_gameobject);
        }

        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("Level2");
    }
}