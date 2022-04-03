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

    public float jump;
    public bool onGround;
    public Transform GroundChecker;
    public float checkRadius;
    public LayerMask Ground;

    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = transform.GetChild(0).GetComponent<Animator>();
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

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }

        onGround = Physics2D.OverlapCircle(GroundChecker.position, checkRadius, Ground);
        if (onGround)
        {
            anim.SetBool("Grounded", true);
        }
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("VerticalSpeed", rb.velocity.y);
    }
}
