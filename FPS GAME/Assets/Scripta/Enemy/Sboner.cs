using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sboner : MonoBehaviour
{

    public GameObject enemy;
    public float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delay, delay);
    }

   public void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
