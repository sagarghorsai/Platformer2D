using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health = 6;
    //Coper = 1, Silver = 3, Gold = 6

    public int coinsCollected = 0;

    public int healthpower = 0;

    private GameObject HUDCamera;
    private GameObject HUDSprite;
    private PlayerController PlayerController;

    public void Start()
    {
        HUDCamera = GameObject.FindGameObjectWithTag("HUDCamera");
        HUDSprite = GameObject.FindGameObjectWithTag("HUDScore");
        PlayerController = GetComponent<PlayerController>();

    }

    public void TakeDamage(int damange, bool playHitReaction)
    {
        health = health - damange;
        HUDCamera.GetComponent<GUIGame>().UpdateHealth(health);
        PlayerController.PlayDamageAudio();
    }
 

    public void CollectedCoin(int coinValue)
    {
        coinsCollected += coinValue;
        HUDSprite.GetComponent<CoinCounter>().value = coinsCollected;
    }

    public void CollectedHealth(int healthpower)
    {
        health = health + healthpower;
        HUDCamera.GetComponent<GUIGame>().UpdateHealth(health);
    }

}
