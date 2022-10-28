using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float racketspeed;

    private Rigidbody2D rb;
    private Vector2 racketdirection;
    public GameObject Player1B;




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

    }


    private void FixedUpdate()
    {
        rb.velocity = racketdirection * racketspeed;
    }
}
