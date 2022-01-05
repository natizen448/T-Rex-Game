using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    CapsuleCollider2D cap;
    Animator anim;
    [SerializeField] private float JumpSpeed;

    private bool isGround = false;
    private float jumpCount = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cap = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jumping();
        ResetJumpCount();
        GroundCheck();
        RunnerPhysic();
    }

    void Jumping()
    {
        if(Input.GetKey(KeyCode.Space) && isGround && jumpCount > 0)
        {
            jumpCount--;
            anim.SetBool("isJump", true);
            rb.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
        }
        
    }    

    void RunnerPhysic()
    {
        if(rb.velocity.y > 0 && !isGround)
        {
            SetPhysic(1f, 8f);
        }

        if(rb.velocity.y < 0)
        {
            SetPhysic(4f, 0);
        }
    }

    void SetPhysic(float gravity,float drag)
    {
        rb.gravityScale = gravity;
        rb.drag = drag;
    }
    
    void ResetJumpCount()
    {
        if(rb.velocity.y == 0 && isGround)
        {
            anim.SetBool("isJump", false);
            jumpCount = 1;
        }
    }

    void GroundCheck()
    {
        Vector2 playerFloor = new Vector2(cap.transform.position.x, cap.transform.position.y );
        RaycastHit2D ray = Physics2D.Raycast(playerFloor, Vector2.down, 0.5f, LayerMask.GetMask("Grand"));
        Debug.DrawRay(playerFloor, Vector2.down, Color.red, 0.5f);

        if (ray.collider == null)
            isGround = false;
        else
            isGround = true;
            
    }
}
