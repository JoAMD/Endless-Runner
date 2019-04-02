using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float maxDistance = 10f, speed = 10f;
    private float initYCoord;
    private bool isMoving = false;

    private Vector2 targetPos;

    public int health = 3;

    private void Start()
    {
        initYCoord = transform.position.y;
    }

    void Update()
    {//transform.position.y <= initYCoord + maxDistance && 

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (!isMoving && transform.position.y < initYCoord + maxDistance && Input.GetKey(KeyCode.UpArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + maxDistance);
            isMoving = true;
        }
        else if (!isMoving && transform.position.y > initYCoord - maxDistance && Input.GetKey(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - maxDistance);
            isMoving = true;
        }

        if(transform.position == new Vector3(targetPos.x, targetPos.y, transform.position.z))
        {
            isMoving = false;
        }

    }
}
