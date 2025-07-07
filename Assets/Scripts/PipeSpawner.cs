using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	public GameObject pipes;
	public float spawnRate = 2f;
	private float timer = 0;
	public float spawnVerticleOffset = 1.2f;
	// Start is called before the first frame update
	void Start()
	{
		SpawnPipes();
		//Debug.Log("In the start method of pipe spawner.");
	}

	// Update is called once per frame
	void Update()
	{
		if (timer < spawnRate)
		{
			timer += Time.deltaTime;
		}
		else
		{
			SpawnPipes();
		}
	}

	void SpawnPipes()
	{
		float minOffset = transform.position.y - spawnVerticleOffset;
		float maxOffset = transform.position.y + spawnVerticleOffset;

		Instantiate(pipes, new Vector3(transform.position.x, Random.Range(minOffset, maxOffset), transform.position.z), transform.rotation);
		timer = 0;
	}
}
