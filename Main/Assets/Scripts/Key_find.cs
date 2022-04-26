using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_find : MonoBehaviour
{
   private bool pickUp;
   private void Update()
    {
        if(pickUp && Input.GetKeyDown(KeyCode.P))
        {
            Destroy(gameObject);
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
            pickUp = false; ;
        }
    }
}
