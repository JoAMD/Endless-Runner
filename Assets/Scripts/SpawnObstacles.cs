using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    private int spawnStyle;
    public GameObject ObstaclePat01, ObstaclePat02, ObstaclePat12;

    public float timeDiffBtwSpawn = 2f, nextSpawnTime = 0f;

    private float timeDiffBtwDecr = 4f, nextTimeDecr = 2f;

    // Update is called once per frame
    void Update()
    {

        if(Time.time >= nextTimeDecr && timeDiffBtwSpawn > 1.1f)
        {
            //Debug.Log(timeDiffBtwSpawn);
            timeDiffBtwSpawn -= 0.1f;
            nextTimeDecr = Time.time + timeDiffBtwDecr;
        }

        if(Time.time >= nextSpawnTime)
        {
            spawnStyle = Random.Range(0, 3);
            if(spawnStyle == 0)
            {
                Instantiate(ObstaclePat01, transform, true);
            }
            else if(spawnStyle == 1)
            {
                Instantiate(ObstaclePat02, transform, true);
            }
            else
            {
                Instantiate(ObstaclePat12, transform, true);
            }
            nextSpawnTime = Time.time + timeDiffBtwSpawn;
        }
        Debug.Log(timeDiffBtwSpawn);
    }
}
