using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnded = false;
    public float restartDelay = 1f;
     
 
    // Update is called once per frame
    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
}
