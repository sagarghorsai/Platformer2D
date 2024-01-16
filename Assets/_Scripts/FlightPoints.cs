using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPoints : MonoBehaviour
{
    public GameObject wayPointA;
    public GameObject wayPointB;

    public float speed = 1.0f;
    public bool shouldChangeFacing = false;
    public bool isPlatform = false;

    private bool directinonAB = false;

    void FixedUpdate()
    {
        if (transform.position == wayPointA.transform.position &&
            directinonAB == false || transform.position== wayPointB.transform.position&&
            directinonAB ==true)
        {
            directinonAB = !directinonAB;

            if (shouldChangeFacing)
            {
                gameObject.GetComponent<EnemyController>().Flip();
            }
        }

        if (directinonAB)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPointB.transform.position, speed * Time.fixedDeltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPointA.transform.position, speed * Time.fixedDeltaTime);

        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isPlatform && (collider.tag == "Player" || collider.tag == "Enemy"))
        {
            collider.gameObject.transform.parent = gameObject.transform;
        }

    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (isPlatform && (collider.tag == "Player" || collider.tag == "Enemy"))
        {
            collider.gameObject.transform.parent = null;
        }
    }
}
