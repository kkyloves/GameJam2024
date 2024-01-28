using System;
using System.Collections;
using Script.Managers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Sprite idleSprite;
    [SerializeField] private Sprite[] walkingSprites;
    
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(MoveAnimation());
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }
    
    private IEnumerator MoveAnimation()
    {
        var walkerCount = 0;
        while (true)
        {
            while (horizontal.Equals(0))
            {
                spriteRenderer.sprite = walkingSprites[0];
                walkerCount = 0;
                SoundManager.Instance.StopCatFootStepSFX();
                yield return null;
            }
            
            SoundManager.Instance.PlayCatFootStepSFX();
            if (walkerCount >= walkingSprites.Length)
            {
                walkerCount = 0;
            }

            spriteRenderer.sprite = walkingSprites[walkerCount];
            walkerCount++;
            yield return new WaitForSeconds(0.3f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void StartAnimation()
    {
        
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}