using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject[] gameObjects;


    public bool isTriggered = false;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && !isTriggered)
        {
            isTriggered = true;

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.SetActive(true);
            }
        }
    }

}
