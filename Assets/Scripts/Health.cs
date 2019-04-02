using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Text text;

    public Transform player;
    private string health;

    // Start is called before the first frame update
    void Start()
    {
        health = player.GetComponent<PlayerController>().health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<PlayerController>().health.ToString();
        text.text = health;
    }
}
