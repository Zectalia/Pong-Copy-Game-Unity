using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    public float StartSpeed;
    public float ExtraSpeed;
    public float MaxExtraSpeed;
    public bool Player1Start = true;
    public float speedM;
    public Color Highspeedcolor;
    public Color LowSpeedcolor;

    private int HitCounter = 0;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public TrailRenderer tr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }

    public IEnumerator Launch()
    {
        RestartBall();
        HitCounter = 0;
        yield return new WaitForSeconds(1);

        if (Player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }

    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed = StartSpeed + HitCounter * ExtraSpeed;
        rb.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (HitCounter * ExtraSpeed < MaxExtraSpeed)
        {
            HitCounter++;
        }
    }
    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > speedM)
        {
            sr.color = Highspeedcolor;
            tr.startColor = Highspeedcolor;
            tr.endColor = Highspeedcolor;
            
        }
        else
        {
            sr.color = LowSpeedcolor;
            tr.startColor = LowSpeedcolor;
            tr.endColor = LowSpeedcolor;
        }

    }

}