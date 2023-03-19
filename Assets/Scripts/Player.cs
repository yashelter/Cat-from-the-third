using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundLayer;

    protected Transform position;
    protected Animator animator;
    protected Rigidbody2D physicShape;

    public int maxJumps = 2;
    public int jumpsLeft = 2;

    public float jumpPower = 2f;
    public float checkRadiusToGround;
    public float movementSpeed = 2f;

    public bool isJumping = false;
    public bool isFliped = false;

    private bool isGrounded;


    void Start()
    {
        position = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        physicShape = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        float x = Input.GetAxis("Horizontal"),
              y = Input.GetAxis("Vertical");

        AnimationMovement(new float[] { x, y });

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && jumpsLeft > 0)
        {
            Jump();
        }
        physicShape.velocity = (new Vector3(x * movementSpeed, physicShape.velocity.y, 0));

    }
    /// <summary>
    /// Производит все необходимые анимации
    /// </summary>
    /// <param name="ways"></param>
    private void AnimationMovement(float[] ways)
    {
        float x = ways[0], y = ways[1];
        if (x < 0 && isFliped || x > 0 && !isFliped) Flip();
        if (x != 0) animator.SetBool("isRunning", true);
        else animator.SetBool("isRunning", false);
    }
    private void FixedUpdate()
    {
        if (jumpsLeft < maxJumps && physicShape.velocity.y <= 0)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadiusToGround, groundLayer);
        }
        if (isGrounded && isJumping)
        {
            isJumping = false;
            animator.SetBool("isLanded", true);
            jumpsLeft = maxJumps;
        }

    }
    protected void Jump()
    {
        jumpsLeft--;
        isJumping = true;
        isGrounded = false;
        animator.SetTrigger("isJump");
        animator.SetBool("isLanded", false) ;
        physicShape.velocity = (new Vector3(physicShape.velocity.x, 1f * jumpPower, 0));

    }
    protected void Flip()
    {
        isFliped = !isFliped;
        position.localScale = new Vector3(-position.localScale.x, position.localScale.y, 0);
    }
}
