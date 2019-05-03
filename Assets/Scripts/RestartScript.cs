using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public HighScore highScoreScript;

    public void restart(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
        
        //highScoreScript = FindObjectOfType<Canvas>().GetComponentInChildren<HighScore>();
        //highScoreScript.compareScore();
    }
}
