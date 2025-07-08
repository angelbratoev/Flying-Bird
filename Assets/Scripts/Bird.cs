using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject bird;
    public Rigidbody2D myRigidBody;
    public float flapPower = 1;
    public bool isAlive = true;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            gameOver.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidBody.velocity = Vector2.up * flapPower;
        }

        if (transform.position.y < -4)
        {
            Destroy(bird);
            Debug.Log("Bird destroyed!");
        }
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer == 6)
		{
            isAlive = false;
			Debug.Log("Bird is dead!");
		}
	}
}
