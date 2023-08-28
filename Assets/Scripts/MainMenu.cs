using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        
    }

    public void PlayerVSIA() 
    {
        SceneManager.LoadScene("PLAYERVSIA");
    }

    public void PlayerVsPlayer()
    {
        SceneManager.LoadScene("PLAYERVSPLAYER");

    }
}
