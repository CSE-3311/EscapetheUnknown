 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterMove : MonoBehaviour
{
	public float moveSpeed = 5f ;
     public Rigidbody2D rb;
     Vector2 movement;
     public Animator animator;
     public int counterkey = 0;
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
		

	}
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.transform.tag == "enemy")
		{
			Debug.Log("Collision detected");
			SceneManager.LoadScene("GameOver");
		}
          
		if(collider.transform.tag == "key")
		{
			Debug.Log("key collected");
               counterkey+=1;

               if(counterkey == 3)
               {
                    SceneManager.LoadScene("Game");
               }
			//add key count to the debug log
			//add win scene
			//SceneManager.LoadScene("Win");
		}
		
		
	}

}