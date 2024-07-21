using UnityEngine;

public class Monster : MonoBehaviour, IInteractable
{
	public void Interact()
	{
		InGameManager.Instance.GameOver();
		// InGameManager에서 게임 종료 루틴 실행. (GameOver 메서드)
		// +
	}
}
