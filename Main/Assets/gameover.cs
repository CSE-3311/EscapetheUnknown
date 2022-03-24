using UnityEngine;

public class gameover : MonoBehaviour
{
	public GameManager gameManager;
	void OnTriggerEnter ()
	{
		gameManager.EndGame();
	}


}
