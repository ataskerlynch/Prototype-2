using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

private int score = 0;
private int lives = 3;
private bool gameOverFlag = false;

    // Update player lives
    public void updateLives(int value)
    {
        lives += value;
        // If there are no more lives then display Game Over message and set gameOverFlag so no further updates are made
        if (lives <= 0)
        {
            Debug.Log("Game Over - Score: " +  score);
            gameOverFlag = true;
            lives = 0;
        }
        else
        {
            Debug.Log("Lives: " + lives + " - Score: " + score);
        }
    }

    // Update player score
    public void updateScore(int value)
    {
        // only update score if game is still active
        if (gameOverFlag == false)
        {
            score += value;
            if (score <= 0) 
            {
                score = 0;
            }
            Debug.Log("Lives: " + lives + " - Score: " + score);
        }
    }
}
