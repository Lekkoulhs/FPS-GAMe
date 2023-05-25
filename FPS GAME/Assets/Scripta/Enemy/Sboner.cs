using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sboner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject secondaryenemy;
    private int counter = 0;
    public int howmanytype1 = 0;
    public bool want2types = false;
    public float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delay, delay);
    }

   public void SpawnEnemy()
    { 
        if (want2types== false)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
       else if (want2types== true && counter <= howmanytype1)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            counter++;
        }
        else
        {
            Instantiate(secondaryenemy, transform.position, Quaternion.identity);
            counter = 0;
        }
    }
}
