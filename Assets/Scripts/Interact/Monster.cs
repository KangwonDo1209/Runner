using UnityEngine;

public class Monster : MonoBehaviour, IInteractable
{
	public void Interact()
	{
		InGameManager.Instance.GameOver();
		// InGameManager���� ���� ���� ��ƾ ����. (GameOver �޼���)
		// +
	}
}
