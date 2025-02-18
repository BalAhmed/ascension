using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.linearVelocityY);
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, speed);
        }
    }
}
