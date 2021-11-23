using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadLevel(string TestGame)
    {
        SceneManager.LoadScene(TestGame);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
