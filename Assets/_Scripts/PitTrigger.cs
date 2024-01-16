using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitTrigger : MonoBehaviour
{
    PlayerStats stats;
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            GameObject trigger = GetNearestActiveCheckpoint();
            if (trigger != null)
            {
                collider.transform.position = trigger.transform.position;
            }
            else
            {
                Debug.LogError("No valid Checkpoint");
            }
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
            stats.TakeDamage(2, false);
        }
        else
        {

            Destroy(collider.gameObject);
        }

       

    }

    GameObject GetNearestActiveCheckpoint()
    {
        GameObject[] checkPoints = GameObject.FindGameObjectsWithTag("Checkpoint");

        GameObject nearestCheckPoint = null;

        float shortestDistance = Mathf.Infinity;

        foreach (GameObject checkPoint in checkPoints)
        {
            Vector3 checkPointPosition = checkPoint.transform.position;
            float distance = (checkPointPosition - transform.position).sqrMagnitude;

            CheckpointTriger trigger = checkPoint.GetComponent<CheckpointTriger>();
            if (distance < shortestDistance && trigger.isTriggered)
            {
                nearestCheckPoint = checkPoint;
                shortestDistance = distance;
            }
        }
        return nearestCheckPoint;

    }


}
