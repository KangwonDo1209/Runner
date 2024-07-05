using UnityEngine;
using Singleton;
using TMPro;
using UnityEngine.EventSystems;

public class UIManager : Singleton<UIManager>
{
	public enum UIState { LOBBY = 0, INGAME = 1, PAUSE = 2, OVER = 3 };
	public TextMeshProUGUI textMeshProUGUI;
	public GameObject[] independentPanels;
	public GameObject[] firstSelectedButtons;
	public UIState currentState;

	private void Start()
	{
		ChangePanel(UIState.LOBBY);
	}

	public void ChangeScoreText(int value)
	{
		textMeshProUGUI.text = value.ToString();
	}
	public void SelectFirstButton(UIState state)
	{
		if (EventSystem.current.currentSelectedGameObject != null) return;

		GameObject buttonObject = firstSelectedButtons[(int)state];
		if (buttonObject != null)
			EventSystem.current.SetSelectedGameObject(buttonObject);
	}
	public void ChangePanel(UIState state)
	{
		foreach (GameObject panel in independentPanels)
		{
			panel.SetActive(false);
		}
		EventSystem.current.SetSelectedGameObject(null);
		currentState = state;
		independentPanels[(int)state].SetActive(true);
		SelectFirstButton(state);
	}

}
