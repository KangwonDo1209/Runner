using UnityEngine;
using Singleton;
using System.Collections;
public class InGameManager : Singleton<InGameManager>
{
	public float addScorePeriod;
	public int unitScore;
	public bool isGaming = false;
	public bool playing = false;
	Coroutine ScorePeriodCoroutine;


	public void GameStart()
	{
		if (!playing)
		{
			GameResume();
			playing = true;
		}
	}
	public void GameOver()
	{
		playing = false;
		UIManager.Instance.ChangePanel(UIManager.UIState.OVER);
		// ScoreManager.Instance.... --> 최종 점수 및 최고 기록 출력 기능
	}

	public void ChangeGameState()
	{
		if (playing)
		{
			if (isGaming) { GameStop(); }
			else { GameResume(); }
		}
	}

	public void GameResume()
	{
		if (isGaming) return;
		isGaming = true;
		UIManager.Instance.ChangePanel(UIManager.UIState.INGAME);
		SpawnManager.Instance.GameStart();
		PlayerController.Instance.animator.SetBool("isGaming", true);
		PlayerController.Instance.BreakY();
		ScorePeriodCoroutine = StartCoroutine(GetScorePeriodCally(unitScore, addScorePeriod));
	}
	public void GameStop()
	{
		if (!isGaming) return;
		isGaming = false;
		UIManager.Instance.ChangePanel(UIManager.UIState.PAUSE);
		SpawnManager.Instance.GameStop();
		PlayerController.Instance.animator.SetBool("isGaming", false);
		PlayerController.Instance.FreezeY();
		StopCoroutine(ScorePeriodCoroutine);
	}
	IEnumerator GetScorePeriodCally(int score, float period)
	{
		if (period < 0.01f) yield break; // 짧은 간격으로 인한 과부하 방지
		while (true)
		{
			ScoreManager.Instance.AddScore(score);
			yield return new WaitForSeconds(period);
		}
	}
}