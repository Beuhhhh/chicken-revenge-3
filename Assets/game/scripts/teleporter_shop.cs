using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter_shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        //if player collides for 2 seconds start level game_horde
        if (col.gameObject.tag == "player")
        {
            Application.LoadLevel("shop");
            col.gameObject.transform.position = transform.position;
            transform.Rotate(new Vector3(0, 0, 90 * Time.deltaTime));
        }

    }
}
