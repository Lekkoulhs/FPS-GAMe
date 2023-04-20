using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBasicAi : MonoBehaviour


{
    private Animator anim;
    private NavMeshAgent pathfinder;
    private Transform target;

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