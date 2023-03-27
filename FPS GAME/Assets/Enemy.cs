using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{

   
    public bool isHit = false;

    [Header("Customizable Options")]

    public float Health;

    public float Damage;
    public GameObject new_gameobject;


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
            //code death animation 
            Destroy(new_gameobject);
        }
    }
}
