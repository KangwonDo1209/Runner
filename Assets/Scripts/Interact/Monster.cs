using UnityEngine;

public class Monster : MonoBehaviour, IInteractable
{
	public void Interact()
	{
		InGameManager.Instance.GameStop();
		// InGameManager���� ���� ���� ��ƾ ����. (GameOver �޼���)
		// +
	}
}
