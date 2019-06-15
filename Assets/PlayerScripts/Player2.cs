using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Analytics;
public class Player2 : MonoBehaviour
{

    public Rigidbody2D rb;
    float speed = 700f;
    public static bool lost = false;
    private string playerTwoLost = "Player 2 Lost";


    public void toRight()
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
    }

    public void toLeft()
    {
        rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, 0);
    }

    public void velocityZero()
    {
        rb.velocity = Vector2.zero;
    }


    public void toUp()
    {
        rb.velocity = new Vector2(0, speed * Time.fixedDeltaTime);
    }

    public void toDown()
    {
        rb.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            Debug.Log("We lost");
            lost = true;
            Analytics.CustomEvent("Player2_CrashCar", new Dictionary<string, object>
            {
                {"Who lose?", playerTwoLost }
            });
        }

        if (collision.tag == "Corpo2")
        {
            Destroy(gameObject);
        }

    }

}
