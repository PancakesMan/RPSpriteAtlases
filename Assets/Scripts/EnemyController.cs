using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f; // Controls the speed of the enemy
    public float jumpForce = 5.0f; // Controls the jump force of the enemy

    private Rigidbody2D rb; // Stores a reference to the Rigidbody2D of the enemy
    private bool facingRight = true; // Keeps track of the direction the enemy is facing
    private bool jumping; // Keeps track of whether the enemy is in the air

    // Start is called before the first frame update
    void Start()
    {
        // Gets a reference to the Rigidbody2D on the object and stored it in the rb variable
        rb = GetComponent<Rigidbody2D>();

        // Makes the enemy randomly change it's direction with a 50% chance
        if (Random.Range(0,2) == 0)
        {
            Flip();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Sets the velocity of the enemy to +5 for moving right and -5 for moving left
        rb.velocity = new Vector2(speed * (facingRight ? 1 : -1), rb.velocity.y);
    }

    // Flips the sprite of the enemy
    void Flip()
    {
        // Flips to boolean storing direction
        facingRight = !facingRight;

        // Copies the value of the field transform.localScale
        Vector3 theScale = transform.localScale;

        // Inverts the value
        theScale.x *= -1;

        // Sets the value of the copy to the original
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Checks if the enemy has hit a wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            // If it has, change it's direction
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Checks if the enemy entered an AutoJump area
        if(collision.gameObject.CompareTag("AutoJump"))
        {
            // Randomly makes the enemy jump with an approx. 33% chance
            if (Random.Range(0, 3) == 1)
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }
        }
    }
}
