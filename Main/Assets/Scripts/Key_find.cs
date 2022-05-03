//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Key_find : MonoBehaviour
{
   private bool pickUp;
   private int counterkey = 0;

   private void Update()
    {
        if(pickUp && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            Debug.Log(counterkey);
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Player")
        {
            pickUp = true;
            
        }
   }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pickUp = false; 
            counterkey+=1;
        }
    }
}
