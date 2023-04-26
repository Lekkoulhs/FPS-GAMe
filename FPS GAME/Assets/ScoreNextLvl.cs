using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreNextLvl : MonoBehaviour
{
    public static int enemieskilled = 0;
    public int enemiestokill = 2;
    public string NxtLvl;

    private void Update()
    {
       if (enemieskilled >= enemiestokill)
        {
            ChangeScene();
        }
    }
    public static void EnemyCounter()
    {
        enemieskilled++;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(NxtLvl);
    }
}
