using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
	private Transform playerpos;
    // Start is called before the first frame update
    void Start()
    {
        playerpos = GameObject.FindGameObjectWithTag("Player").transform;
		
    }

    // use lateUpdate to allow
	// character position calculation to be done in update
	// helps with lag if camera movement is done after 
	// the calculation.
    void LateUpdate()
    {
		Vector3 camerapos = transform.position;
		camerapos.x = playerpos.position.x;
		camerapos.y = playerpos.position.y;
		transform.position = camerapos;
    }
}


