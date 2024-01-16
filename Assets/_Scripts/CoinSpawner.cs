using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinSpawnPoint;
    public Object[] coinPrefabs;


    public int force;

    void Start()
    {
        SpawnCoin();
    }


    void SpawnCoin()
    {
        GameObject coin = Object.Instantiate(coinPrefabs[Random.Range(0,coinPrefabs.Length)],
            coinSpawnPoint.transform.position,
            coinSpawnPoint.transform.rotation) as GameObject;

        coin.GetComponent<Rigidbody2D>().AddForce(new Vector2((Random.Range(-120, 120)), force));
    }
  
}
