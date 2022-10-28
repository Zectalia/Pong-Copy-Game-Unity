using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{

    public float racketspeed;

    private Rigidbody2D rb;
    private Vector2 racketdirection;
    public GameObject Player1B;
    public GameObject Player1;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        racketdirection = new Vector2(0, directionY).normalized; 
        if (Input.GetKey(KeyCode.D))
        {
            Player1.SetActive(false);
            Player1B.SetActive(true);
           // rb1.SetActive(false);
          //  rb2.SetActive(true);
            
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Player1.SetActive(true);
            Player1B.SetActive(false);
        }

    }


    private void FixedUpdate()
    {
        rb.velocity = racketdirection * racketspeed;
    }
}
