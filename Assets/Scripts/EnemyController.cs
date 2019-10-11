using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Random.Range(0,2) == 0)
        {
            Flip();
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * (facingRight ? 1 : -1), rb.velocity.y);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("AutoJump"))
        {
            if (Random.Range(0, 3) == 1)
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }
        }
    }
}
