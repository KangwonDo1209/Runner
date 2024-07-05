using UnityEngine;

public class Interact : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D collision)
	{
		IInteractable interactable = collision.gameObject.GetComponent<IInteractable>();
		if (interactable != null) { interactable.Interact(); }
	}


}


