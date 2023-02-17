using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour


{


    [SerializeField]
    public GameObject fox_enemy;
    [SerializeField]
    public GameObject spawnpoint;


    private float startTime;

    public GameObject[] spawnpoints;
    private float startTime;



    // Start is called before the first frame update
    void Start()
    {

        startTime = Time.time;
        spawnpoints = GameObject.FindGameObjectsWithTag("spawnpoint");

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > 3)
        {
            GameObject newEnemy = Instantiate(fox_enemy, spawnpoint.transform.position, Quaternion.identity);
            startTime = Time.time;
        }


        if (Time.time - startTime > 2)
        {
            int randomSpawnpoint = Random.Range(0, spawnpoints.Length);
            GameObject newEnemy = Instantiate(fox_enemy, spawnpoints[randomSpawnpoint].transform.position, Quaternion.identity);
            startTime = Time.time;
        }

        // if (Time.time - startTime > 3)
        // {
        //     GameObject newEnemy = Instantiate(fox_enemy, spawnpoints.transform.position, Quaternion.identity);
        //     startTime = Time.time;
        // }

    }
}