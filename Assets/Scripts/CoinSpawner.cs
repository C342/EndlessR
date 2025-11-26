using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Vector2 coinOffset = new Vector2(0, 1);
    void Start()
    {
        SpawnCoin(); 
    }
    void SpawnCoin()
    {
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;
        Instantiate(coinPrefab, coinPosition, Quaternion.identity);
        }
    }