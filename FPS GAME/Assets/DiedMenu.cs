using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{
    [SerializeField] public string MenuScene;
    

    public void GoMenu()
    {
        SceneManager.LoadScene(MenuScene);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
