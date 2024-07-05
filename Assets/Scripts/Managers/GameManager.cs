using UnityEngine;
using Singleton;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
	public void RestartGame() { SceneManager.LoadScene(0); }
	public void ExitGame() { Application.Quit(); }

}
