using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBasicAi : MonoBehaviour


{
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
    }
}