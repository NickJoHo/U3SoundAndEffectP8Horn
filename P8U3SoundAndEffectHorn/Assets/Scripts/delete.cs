using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate  = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObsstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void update()
    {

    }
    void spawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}

