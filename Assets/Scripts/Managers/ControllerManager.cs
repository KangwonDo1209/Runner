using UnityEngine;
using UnityEngine.InputSystem;
using Singleton;

public class ControllerManager : Singleton<ControllerManager>
{
	public void OnJump(InputAction.CallbackContext value)
	{
		if (value.started)
		{
			PlayerController.Instance.Jump();
		}

	}
	public void OnEsc(InputAction.CallbackContext value)
	{
		if (value.started)
		{
			InGameManager.Instance.ChangeGameState();
		}

	}

	public void OnSelect(InputAction.CallbackContext value)
	{
		if (value.started)
		{
			UIManager.Instance.SelectFirstButton(UIManager.Instance.currentState);
		}
	}

}
