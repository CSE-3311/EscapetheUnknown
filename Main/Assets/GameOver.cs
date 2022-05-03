using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{ 

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    } 

    public void Mainmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
