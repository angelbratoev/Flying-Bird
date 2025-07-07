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
	}

    public void MainMenu()
    {
		SceneManager.LoadScene(SceneEnums.StartMenu);
	}

	public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}
