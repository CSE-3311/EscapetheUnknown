 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
	public float moveSpeed = 5f ;
     public Rigidbody2D rb;
     Vector2 movement;
     public Animator animator;
    // Start is called before the first frame update

    void Update()
    {
          //transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime, 0f);
          movement.x = Input.GetAxisRaw("Horizontal");
          movement.y = Input.GetAxisRaw("Vertical");

          animator.SetFloat("Horizontal",movement.x);
          animator.SetFloat("Vertical",movement.y);
          animator.SetFloat("Speed",movement.sqrMagnitude);  
    }

    void FixedUpdate()
    {
         rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
     }

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "enemy")
		{
			Debug.Log("Collision detected");
		}

	}

}