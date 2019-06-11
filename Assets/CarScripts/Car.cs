using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    float speed = 1f;

    private void Start()
    {
        speed = 10f;
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.up.x, transform.up.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        Destroy(gameObject, 8.0f);
    }

    
}
