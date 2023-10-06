using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private float score;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // retrieve GameManager object so that scores and lives can be adjusted based on collisions
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // If projectile hits an animal then adjust the score
        if ((CompareTag("Projectile") && other.CompareTag("Animal")))
        {
            gameManager.updateScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else
        // If the player hits an animal then adjust the player lives
        if ((CompareTag("Player") && other.CompareTag("Animal")))
        {
            gameManager.updateLives(-1);
        }
    }

}

