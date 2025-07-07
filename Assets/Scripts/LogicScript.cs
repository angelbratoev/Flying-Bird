using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	public int score = 0;
	private bool playerIsAlive;

	private void Update()
	{
		playerIsAlive = GameObject.FindWithTag("Player").GetComponent<Bird>().isAlive;
	}

	public void AddScore(int scoreToAdd)
	{
		if (playerIsAlive)
		{
			score += scoreToAdd;
			scoreText.text = score.ToString();
		}
	}

	
}
