using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonagem : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel;   
    public float jump;
    public GameObject GroundCheck;
    private GroundCheck scriptGround;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scriptGround = GroundCheck.GetComponent<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (rb2d.velocity.magnitude < 5) {
            rb2d.velocity += new Vector2(vel,0)*horizontalInput*Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow)&&scriptGround.taNoChao||Input.GetKey(KeyCode.Space)&&scriptGround.taNoChao) {
            rb2d.velocity = new Vector2(rb2d.velocity.x,jump);
        }
    }
}
