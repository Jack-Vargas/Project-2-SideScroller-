using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
public float WalkForce = 8;
public float JumpForce = 7;
public bool IsFacingRight = true;
public Transform GroundCheck;
private float horizontal = 0;
public LayerMask GroundLayer;
public float YMultiplier = 1f;

void FixedUpdate()
{
    float movehor = Input.GetAxis("Horizontal") * WalkForce;
    rb2D.velocity = new Vector3(movehor, rb2D.velocity.y);
}

void Update()
{
    horizontal = Input.GetAxisRaw("Horizontal");

    Flip();

    if (Input.GetButtonDown("Jump") && IsGrounded() || Input.GetKeyDown(KeyCode.W) && IsGrounded())
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, JumpForce);
    }

    if (Input.GetButtonUp("Jump") && rb2D.velocity.y > 0 || Input.GetKeyUp(KeyCode.W) && rb2D.velocity.y > 0)
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y * 0.5f);
    }
    //spent so much time on the above code and here is what i learned;
    //1. dont put a ; at the end of the GetButtonUp if statement
    //2. in the aformentioned statement i used rb2d.velocity.y instead of JumpForce
    //once all of this was cleared up the code worked fine

}

private void Flip()
{
    if (IsFacingRight && horizontal < 0f || !IsFacingRight && horizontal > 0f)
    {
        IsFacingRight = !IsFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}

public bool IsGrounded()
{
    return Physics2D.OverlapCircle(GroundCheck.position, 0.1f, GroundLayer);
}
}
