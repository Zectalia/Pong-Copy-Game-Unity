using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int ScoreToReach;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public Text Player1ScoreText;
    public Text Player2ScoreText;

    public void Player1Goal()
    {
        Player1Score++;
        Player1ScoreText.text = Player1Score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        Player2Score++;
        Player2ScoreText.text = Player2Score.ToString();
        CheckScore();
    }
    
    private void CheckScore()
    {
        if(Player1Score == ScoreToReach)
        {
            SceneManager.LoadScene(3);
        }
        else if(Player2Score == ScoreToReach)
        {
            SceneManager.LoadScene(4);
        }
    }

}


