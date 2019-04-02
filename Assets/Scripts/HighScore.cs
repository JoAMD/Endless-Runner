using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Text text;

    public Transform scoreText;
    private float score;
    private float highScore = 0f;

    private void Start()
    {
        text.text = "0";
        score = float.Parse(scoreText.GetComponent<Score>().scoreText.text);
        if (score > highScore)
        {
            highScore = score;
            text.text = score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
