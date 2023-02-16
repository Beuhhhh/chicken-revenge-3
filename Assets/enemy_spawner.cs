using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour


{


    [SerializeField]
    public GameObject fox_enemy;





    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("spawnpoint");


    }

    // Update is called once per frame
    void Update()
    {


    }
}
