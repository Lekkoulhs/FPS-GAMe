using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using InfimaGames.LowPolyShooterPack;
using UnityEngine.Analytics;
using TMPro;

public class TimerNextLvl : MonoBehaviour
{
    public  float levelDuration = 180f; 
    private bool levelComplete = false;
    public TextMeshProUGUI timerText;
    public string NxtLvl;
    public Character character;

    public static TimerNextLvl instance;
   

    public static TimerNextLvl Instance
    {
        get
        {
            if (instance == null) instance = TimerNextLvl.FindObjectOfType<TimerNextLvl>();
            return instance;
        }
    }
    private void Start()
    {
       
  
        levelComplete = false;

    }

    private void Update()
    {
       
        if (!levelComplete)
        {
            levelDuration -= Time.deltaTime;
            UpdateTimerDisplay();

            if (levelDuration <= 0f)
            {
                character.cursorLocked = false;
                character.UpdateCursorState();
                SceneManager.LoadScene(NxtLvl);
               
                levelComplete = true;
            }
        }
    }
    private void UpdateTimerDisplay()
    {
        // Convert the timer value to minutes and seconds
        int minutes = Mathf.FloorToInt(levelDuration / 60);
        int seconds = Mathf.FloorToInt(levelDuration % 60);

        // Update the text display with the formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
