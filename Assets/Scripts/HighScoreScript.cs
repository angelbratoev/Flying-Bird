using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreScript : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
