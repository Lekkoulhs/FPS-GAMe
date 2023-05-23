using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countertxt : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    [SerializeField]
    public  int zombiesleft;
    private static countertxt instance;

    public static countertxt Instance
    {
        get
        {
            if (instance == null) instance = countertxt.FindObjectOfType<countertxt>();
            return instance;
        }
    }

    public void Start()
    {
        //scoretext.text = "Zombies left to kill " + zombiesleft.ToString();
    }

    public void Update()
    {

        
    }

    public  void change()
    {
        zombiesleft -= 1;
        scoretext.text = "Zombies left to kill " + zombiesleft.ToString();
    }
}


