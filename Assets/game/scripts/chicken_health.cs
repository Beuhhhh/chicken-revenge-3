using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chicken_health : MonoBehaviour
{
    public int health = 3;
    public bool fox_damage = false;
    // Start is called before the first frame update
    void Start()

    {


    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("menu");
        }
        if (fox_damage == true)
        {
            health -= 1;
            fox_damage = false;
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "fox")
        {
            fox_damage = true;
        }

    }

}

