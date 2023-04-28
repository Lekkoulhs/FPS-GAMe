using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countertxt : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public static int zombiesleft = 10;

    private void Start()
    {
        scoretext.text = "Zombies left to kill " + zombiesleft.ToString();
    }

    public void Update()
    {

        scoretext.text = "Zombies left to kill " + zombiesleft.ToString();
    }

    public static void change()
    {
        zombiesleft -= 1;
    }

}
