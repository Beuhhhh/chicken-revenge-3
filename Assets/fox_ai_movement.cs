using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox_ai_movement : MonoBehaviour


{
    public GameObject target_chicken;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        if (target_chicken == null)
        {
            target_chicken = GameObject.Find("player chicken");
        }
        // fox moves towards player chicken to make fox run away from player -0.01f
        transform.position = Vector3.MoveTowards(transform.position, target_chicken.transform.position, 0.01f);
    }
}