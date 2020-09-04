using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Spawner : MonoBehaviour
{
    public float SpawnRate = 1f;

    public GameObject DogPrefab;

    private float NextTimeToSpawn;

    private void Update()
    {
        if (Time.time >= NextTimeToSpawn)
        {
            Instantiate(DogPrefab, Vector3.zero, Quaternion.identity);
            NextTimeToSpawn = Time.time + 1f / SpawnRate;
        }
    }
}