using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{

    public GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float distance;
    public float speedEnemy;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
	currentPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
	//can add an if statement before transform call to adjust ai behavior
        transform.position = Vector2.MoveTowards(transform.position , playerPos.position, speedEnemy*Time.deltaTime);
    }
}
