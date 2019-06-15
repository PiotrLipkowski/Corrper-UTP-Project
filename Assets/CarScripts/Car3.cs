﻿using UnityEngine;
using UnityEngine.Analytics;
using System.Collections.Generic;
public class Car3 : MonoBehaviour
{
    public Rigidbody2D rb;


    float speed = 1f;
    private string car3Hit = "Car 3 Hit";

    private void Start()
    {
        speed = 14f;
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.up.x, transform.up.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        Destroy(gameObject, 8.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Player2" || collision.tag == "Player3" || collision.tag == "Player4")
        {
            Analytics.CustomEvent("Car3Hit", new Dictionary<string, object>
            {
                {"Which car hit?", car3Hit }
            });
        }
    }
}
