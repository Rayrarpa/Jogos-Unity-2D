using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel = 5f;
    public float jumpForce;
    public GameObject groundCheck;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector2 movimento = new Vector2(HorizontalInput, VerticalInput);

        if (rb2d.velocity.magnitude < 5)
        {
            rb2d.velocity += movimento * vel;
        }

        if (Input.GetKey(KeyCode.Space)) {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }
    }
}