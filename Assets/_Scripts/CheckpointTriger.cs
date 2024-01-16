using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTriger : MonoBehaviour
{
    public bool isTriggered;

    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("checkpointTrigger", false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && !isTriggered)
        {
            isTriggered = true;
            anim.SetBool("checkpointTrigger", true);
        }


    }



   

}




