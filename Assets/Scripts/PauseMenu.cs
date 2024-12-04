using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
}

    void Resume()
    {
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0.0001f;
        GameisPaused = true;
    }

}
