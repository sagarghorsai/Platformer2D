using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int health = 1;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();

            stats.CollectedHealth(health);
            Destroy(gameObject);
        }



    }
}
