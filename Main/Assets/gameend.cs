using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameend : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");

        }


    }
}
