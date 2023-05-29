using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using InfimaGames.LowPolyShooterPack;

public class WINCOND : MonoBehaviour
{
    public string NxtLvl;

    public Character character;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            character.cursorLocked = false;
            character.UpdateCursorState();
            SceneManager.LoadScene(NxtLvl);
        }
    }

}
