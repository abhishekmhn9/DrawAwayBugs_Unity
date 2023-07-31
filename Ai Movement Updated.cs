using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class AI_Movement_updated : MonoBehaviour
{

    public Transform target;
    public float speed = 1f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float angleOffset = 0f;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 direction = target.position - transform.position; // target's pos minus the bug's pos
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.rotation = angle + angleOffset;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveChar(movement);
    }

    void moveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

    }
}
