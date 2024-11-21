using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float speed = 50f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);

    }
}
