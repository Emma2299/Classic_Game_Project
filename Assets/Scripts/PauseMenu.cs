using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1.0f;
            //hides the button when game is unpaused
            pauseUI.SetActive(false);
            //when isPaused is true, this will set it to false
            isPaused = false;
        }

        else
        {
            //pause
            //doesn't affect frame rate, just how fast everything is moving
            Time.timeScale = 0.0f;
            //shows button when the game is paused
            pauseUI.SetActive(true);
            //when isPaused is false, this will set it to true
            isPaused = true;
        }

        //isPaused = !isPaused; is the same function as above t/f
    }

    public void Quit()
    {
        Application.Quit();
    }
}
