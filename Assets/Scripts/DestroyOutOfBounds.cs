using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -2;
    private float leftBound = -20;
    private float rightBound = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
