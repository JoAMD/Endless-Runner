using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : SpawnObstacles
{

    public float obstacleSpeed = 700f;

    public float speedIncrement = 100f;
    public float timeBtwSpeedIncr = 0.1f;

    //public GameObject ObstaclesHolder;

    private float nextSpeedIncrTime;

    //public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //gameOver.SetActive(false);
        transform.GetComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed * Time.deltaTime, 0);
        //ObstaclesHolder = GameObject.FindGameObjectWithTag("ObstaclesHolder");
        //nextSpeedIncrTime = ObstaclesHolder.GetComponent<SpawnObstacles>().nextSpeedIncrTime;
    }

    private void Update()
    {
        if(Time.time >= nextSpeedIncrTime)
        {
            obstacleSpeed += speedIncrement;
            transform.GetComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed * Time.deltaTime, 0);
            nextSpeedIncrTime = Time.time + timeBtwSpeedIncr;
        }
    }

    void FixedUpdate()
    {
        transform.GetComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            {
            other.GetComponent<PlayerController>().health--;
            if(other.GetComponent<PlayerController>().health <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
                //obstacleSpeed = 0;
                //transform.GetComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed * Time.deltaTime, 0);
                //gameOver.SetActive(true);
            }
            //Debug.Log(other.GetComponent<PlayerController>().health);
            Destroy(gameObject);

        }
    }

}
