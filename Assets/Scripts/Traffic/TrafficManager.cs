using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    public GameObject vehiclePrefab; // Prefab for NPC vehicles
    public float trafficSpawnRate = 2.0f; // Rate to spawn vehicles
    public int maxTrafficDensity = 10; // Max vehicles that can be spawned at once

    private List<GameObject> activeVehicles = new List<GameObject>();
    
    void Start()
    {
        StartCoroutine(SpawnTraffic());
    }

    IEnumerator SpawnTraffic()
    {
        while (true)
        {
            if (activeVehicles.Count < maxTrafficDensity)
            {
                SpawnVehicle();
            }
            yield return new WaitForSeconds(trafficSpawnRate);
        }
    }

    void SpawnVehicle()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        GameObject newVehicle = Instantiate(vehiclePrefab, spawnPosition, Quaternion.identity);
        activeVehicles.Add(newVehicle);
    }

    public void RemoveVehicle(GameObject vehicle)
    {
        activeVehicles.Remove(vehicle);
        Destroy(vehicle);
    }
}