using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : EnemyController
{
    private void OnTriggerEnter2D(Collider2D collider)
    { 

        if (collider.tag == "Player")
        {
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
            stats.TakeDamage(1, false);
        }

    }


}
