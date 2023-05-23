using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using InfimaGames.LowPolyShooterPack;

public class ScoreNextLvl : MonoBehaviour
{
    public  int enemieskilled = 0;
    public int enemiestokill = 2;
    public string NxtLvl;

    public Character character;
    private static ScoreNextLvl instance;

    public static ScoreNextLvl Instance
    {
        get
        {
            if (instance == null) instance = ScoreNextLvl.FindObjectOfType<ScoreNextLvl>();
            return instance;
        }
    }

    private void Update()
    {
       if (enemieskilled >= enemiestokill)
        {
            ChangeScene();
        }
    }
    public  void EnemyCounter()
    {
        countertxt.Instance.change();
        enemieskilled++;
    }
    public void ChangeScene()
    {
        character.cursorLocked = false;
        character.UpdateCursorState();
        SceneManager.LoadScene(NxtLvl);
    }
}
