using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag =="Player"){
            SceneManager.LoadScene("GameOver");
            Debug.Log("End game");
        }


    }
}
