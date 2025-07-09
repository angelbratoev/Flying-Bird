using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	public int score = 0;
	public Bird bird;

	private void Update()
	{
		if (!bird.isAlive && score > PlayerPrefs.GetInt("HighScore"))
		{
			PlayerPrefs.SetInt("HighScore", score);
		}
	}

	public void AddScore(int scoreToAdd)
	{
		if (bird.isAlive)
		{
			score += scoreToAdd;
			scoreText.text = score.ToString();
			AudioManager.Instance.Play(AudioManager.SoundType.Point);


		}
	}


}
