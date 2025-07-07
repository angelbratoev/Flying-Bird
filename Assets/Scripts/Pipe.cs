using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject pipe;
    public float movementSpeed;
    public LogicScript logic;
    public int scoreToAdd = 1;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * movementSpeed * Time.deltaTime;

        if (transform.position.x < -7)
        {
            Destroy(pipe);
        }
    }

    
	private void OnTriggerEnter2D(Collider2D collision)
	{
        logic.AddScore(scoreToAdd);
	}
}
