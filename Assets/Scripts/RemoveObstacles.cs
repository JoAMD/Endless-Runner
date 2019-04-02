using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObstacles : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle"))
            Destroy(other.transform.parent.parent.gameObject);
        // BoxCollider2D
    }
}
