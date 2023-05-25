using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Qutu : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }

    [SerializeField] public string MenuScene;




    public void GoMenu()
    {

        SceneManager.LoadScene(MenuScene);
    }
}
