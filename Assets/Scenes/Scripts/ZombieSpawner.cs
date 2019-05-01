using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    private int maxAliveZombies = 25;
    private int currentAliveZombies = 0;
    private float spawnDelay = 2f;
    public GameObject zombie;
    public GameObject spawner;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        if (currentAliveZombies < maxAliveZombies)
        {
            Instantiate(zombie, spawner.transform.position, spawner.transform.rotation);
            currentAliveZombies += 1;
        }
    }
}
