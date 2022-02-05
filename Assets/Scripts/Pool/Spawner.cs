using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] float spawnRate;
    [SerializeField] ObjectPool objectPool;
    [SerializeField] TimeManager tm;
    [SerializeField] bool canSpawn;
    [SerializeField] bool isSpawning;
    private void Update()
    {
        if (tm.isTimerActive)
        {
            StopCoroutine(SpawnObject());
        }
        else
        {
            canSpawn = true;
        }

        if (canSpawn && !isSpawning)
        {
            isSpawning = true;
            StartCoroutine(SpawnObject());
        }
    }
    IEnumerator SpawnObject()
    {
        int randomCounter = Random.Range(0, objectPool.pools.Length);
        GameObject obj = objectPool.GetPooledObject(randomCounter);
        int randomIndex = Random.Range(0, spawnPoints.Count);
        obj.transform.position = spawnPoints[randomIndex].position;
        obj.transform.parent = transform;
        yield return new WaitForSeconds(spawnRate);
        isSpawning = false;
    }
}
