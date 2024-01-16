using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamage : MonoBehaviour
{
    public int damange = 1;
    public bool playerHitReaction = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
            stats.TakeDamage(damange, playerHitReaction);
        }

    }
}
