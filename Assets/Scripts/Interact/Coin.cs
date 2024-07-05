using UnityEngine;

public class Coin : MonoBehaviour, IInteractable
{
	public int coinValue;
	public void Interact()
	{
		ScoreManager.Instance.AddScore(coinValue);
		Destroy(gameObject);
	}
}
