using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballAudioScript : MonoBehaviour
{
    AudioSource src;
    Rigidbody2D rb;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
}
}
