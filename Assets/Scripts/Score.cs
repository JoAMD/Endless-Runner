using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    private float startTime;
    public SpawnObstacles spawnObstacles;

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        scoreText.text = Mathf.Round((Time.time - startTime) / spawnObstacles.timeDiffBtwSpawn ).ToString();
    }
}
