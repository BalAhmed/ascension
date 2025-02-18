using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    bool left = false;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        // Move
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocityY);
        

        // Rotate Char
        if (moveHorizontal < 0 && !left)
        {
            RotateChar();
        }
        else if (moveHorizontal > 0 && left)
        {
            RotateChar();
        }


        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    void RotateChar()
    {
        left = !left;
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
