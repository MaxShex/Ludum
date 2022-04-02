using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 move;
    public float speed = 2f;
    public SpriteRenderer sr;
    public bool faceRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }

    
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);

        if ((move.x > 0 && !faceRight) || (move.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
}
