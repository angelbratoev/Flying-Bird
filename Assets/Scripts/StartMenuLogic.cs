using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuLogic : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void StartGame()
	{
		SceneManager.LoadScene(SceneEnums.PlayingLevel);

		AudioManager.Instance.ChangeTrack(AudioManager.SoundType.PlayingLevel);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(SceneEnums.StartMenu);

		if (AudioManager.Instance.GetCurrentSoundType() != AudioManager.SoundType.StartMenu)
		{
			AudioManager.Instance.ChangeTrack(AudioManager.SoundType.StartMenu);
		}
	}

	public void HowToPlay()
	{
		SceneManager.LoadScene(SceneEnums.HowToPlay);
	}

	public void ExitGame()
	{
		Application.Quit();
		Debug.Log("Game is exiting...");
	}
}
