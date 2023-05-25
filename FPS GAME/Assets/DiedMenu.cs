using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using InfimaGames.LowPolyShooterPack;

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

    public void respawn()
    {
      
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }
}
