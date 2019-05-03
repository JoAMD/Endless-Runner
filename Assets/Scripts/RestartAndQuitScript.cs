using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndQuitScript : MonoBehaviour
{

    public HighScore highScoreScript;

    public void restart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Application.Quit();
    }
}
