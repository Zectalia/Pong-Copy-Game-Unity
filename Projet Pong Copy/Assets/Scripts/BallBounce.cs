using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameObject HitSFX;

    public BallMove BallMovement;
    public ScoreManager scoreManager;


    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketheight = collision.collider.bounds.size.y;

        float PositionX;
        if(collision.gameObject.name == "Player 1")
        {
            PositionX = 1;
        }
        else
        {
            PositionX = -1;
        }

        float PositionY = (ballPosition.y - racketPosition.y) / racketheight;

        BallMovement.IncreaseHitCounter();
        BallMovement.MoveBall(new Vector2(PositionX, PositionY));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }
        else if(collision.gameObject.name == "RightBorder")
        {
            scoreManager.Player1Goal();
            BallMovement.Player1Start = false;
            StartCoroutine(BallMovement.Launch());
        }
        else if(collision.gameObject.name == "LeftBorder")
        {
            scoreManager.Player2Goal();
            BallMovement.Player1Start = true;
            StartCoroutine(BallMovement.Launch());
        }

        Instantiate(HitSFX, transform.position, transform.rotation);
    } 

}
