using UnityEngine;
using Singleton;
using UnityEngine.UI;
public class ScoreManager : Singleton<ScoreManager>
{
	private int score = 0;
	public int _score
	{
		set
		{
			// Score UI ¼öÁ¤
			UIManager.Instance.ChangeScoreText(value);
			score = value;
		}
		get
		{
			return score;
		}
	}
	public void SetScore(int value) { _score = value; }
	public void AddScore(int value) { _score += value; }
}
