using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;

    //creates position limit variable for rando spawn points
    public float xPositionLimit;
    // Start is called before the first frame update
    public float spawnRate;
   
    //respawn timer variable
    void Start()
    {   //spawns enemy
       // SpawnSpike();
       StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function spawns spikes at random location
    void SpawnSpike()
    {
        float randomX = Random.Range(-xPositionLimit,xPositionLimit);

        Vector2 spawnPosition = new Vector2(randomX,transform.position.y);

        Instantiate(enemy,spawnPosition,Quaternion.identity);
    }

    //repeats SpawnSpike function
    void StartSpawning()
    {
        InvokeRepeating("SpawnSpike",1f, spawnRate);

    }

    //for gameover
    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
    
    }

}

