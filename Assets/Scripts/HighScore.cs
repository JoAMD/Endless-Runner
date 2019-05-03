using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Text text;

    private int lastScore;
    public Score scoreScript;

    private void Start()
    {
        compareScore();
    }

    public void compareScore()
    {
        lastScore = StaticData.lastScore;
        if (lastScore > StaticData.highScore)
        {
            StaticData.highScore = lastScore;
        }

        text.text = StaticData.highScore.ToString();
    }
}
