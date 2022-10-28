using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour
{

    public float racketspeed;

    private Rigidbody2D rb;
    private Vector2 racketdirection;
    public GameObject Player2;
    public GameObject Player2B;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");

        racketdirection = new Vector2(0, directionY).normalized;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player2.SetActive(false);
            Player2B.SetActive(true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player2.SetActive(true);
            Player2B.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = racketdirection * racketspeed;
    }
}
