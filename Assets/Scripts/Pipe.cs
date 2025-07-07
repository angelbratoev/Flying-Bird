using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject pipe;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
