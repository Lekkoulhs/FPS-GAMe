using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public string StartingScene;
    public void PlayGame() 
    {
        SceneManager.LoadScene(StartingScene);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Options()
    {

    }
}

