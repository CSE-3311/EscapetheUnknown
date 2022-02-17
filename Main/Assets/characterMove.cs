using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
	public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
         moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime, 0f);
    }
}
