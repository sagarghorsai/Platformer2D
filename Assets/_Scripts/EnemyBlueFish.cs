using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlueFish : EnemyController
{
    public float verticalSpeed = 10.0f; 

    private bool isMovingUp = true;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (transform.position.y >= 5.0f)
        {
            isMovingUp = false;
        }
        else if (transform.position.y <= -1.0f)
        {
            isMovingUp = true;
        }

        animator.SetBool("MovingUp", isMovingUp);

        float verticalVelocity = isMovingUp ? verticalSpeed : -verticalSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, verticalVelocity);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
            stats.TakeDamage(1, false);
        }
    }
}
