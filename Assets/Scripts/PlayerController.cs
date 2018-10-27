using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource[] audioSources;
    CircleCollider2D col;


    Vector2 input;

    public float speed =5;

    private void Awake()
    {
        SetReferences();
    }

    private void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        if(input.sqrMagnitude > 1)
        {
            input.Normalize();
        }


        Move();
    }

    void SetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSources = GetComponents<AudioSource>();
        col = GetComponentInChildren<CircleCollider2D>();
    }

    void Move ()
    {
        Vector2 velocity = input;
        velocity *= speed;

        rb.velocity = velocity;
    }
}
