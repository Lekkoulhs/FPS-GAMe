using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBasicAi : MonoBehaviour


{
  /*  [Header("Reference")]
    public AudioSource audioSource;

    public AudioClip stepSound;*/
    public Animator anim;
    private NavMeshAgent pathfinder;
    public Transform target;

    void Start()
    {
        anim = GetComponent<Animator>();
        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player").transform;

    }
    void Update()
    {
        anim.SetBool("IsWalking", true);
        
        pathfinder.SetDestination(target.position);
       // PlayWalkingSound();
    }

  /*  public void PlayWalkingSound()
    {
        audioSource.pitch = (Random.Range(0.9f, 1.1f));
        audioSource.PlayOneShot(stepSound, Mathf.Abs(Input.GetAxis("Horizontal") / 10));
    }*/
}