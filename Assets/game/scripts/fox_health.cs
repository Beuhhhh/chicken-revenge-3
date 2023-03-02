using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox_health : MonoBehaviour
{

    public int health = 3;
    public bool bullet_hit_fox = false;
    public GameObject blood_s;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()

    {

        // if fox health is 0, fox is destroyed and spawns blood
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(blood_s, transform.position, Quaternion.identity);

        }
        if (bullet_hit_fox == true)
        {
            health -= 1;
            bullet_hit_fox = false;
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bullet")
        {
            bullet_hit_fox = true;
            Destroy(col.gameObject);
        }

    }
}
