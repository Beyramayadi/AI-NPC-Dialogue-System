using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 50f;
    public Rigidbody2D rb;
    public int facingDirection = 1;
    public Animator anim;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);


        if (horizontal > 0 && transform.localScale.x < 0 ||
        horizontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }

        anim.SetFloat("horizontal", Mathf.Abs(horizontal));
        anim.SetFloat("vertical", Mathf.Abs(vertical));

    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
