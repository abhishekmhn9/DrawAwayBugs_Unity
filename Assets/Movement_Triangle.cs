using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Triangle : MonoBehaviour
{
    public float speed = 2.5f;
    
    private Rigidbody2D rb;
    private Collider2D coll;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        SetRandomDirection();
    }

    void Update()
    {
        
        rb.velocity = direction * speed;
    }

    void SetRandomDirection()
    {
        
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with:" + collision.gameObject.name);
    }
}
