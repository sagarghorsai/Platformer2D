using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    public GameObject poppedStatePrefab;

  
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Vector3 heading = transform.position - collider.gameObject.transform.position;

        float distance = heading.magnitude;
        Vector3 direction = heading / distance;

        if (
            (direction.x < 0.1 && direction.x > -1.1)
            && (direction.y < 1.1 && direction.y > 0.4) &&
            collider.tag == "Player")
        {
            CoinPop();
        }

    }
    void CoinPop()
    {
        poppedStatePrefab.SetActive(true);
        gameObject.SetActive(false);
        
    }


}
