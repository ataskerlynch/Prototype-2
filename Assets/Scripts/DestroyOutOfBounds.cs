using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 25;
    private float lowerBound = -5;
    private float leftBound = -25;
    private float rightBound = 25;
    private int deductScore = 2;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Get GameManager object so that score can be deducted if animal leaves screen
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if gameobject has left the defined boundries
        if (transform.position.z > topBound| transform.position.z < lowerBound|| transform.position.x > rightBound || transform.position.x < leftBound)
        {
            // if the object is an animal then adjust score
            if (tag=="Animal")
            {
                gameManager.updateScore(-deductScore);
            }
            Destroy(gameObject);
        }
    }
}
