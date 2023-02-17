using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet_movement : MonoBehaviour

{
    private Vector3 dir;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

    }




    public void shootBullet(string direction)
    {
        Transform sprite = transform.GetChild(0);
        if (direction == "up")
        {
            dir = Vector3.up;
            // transform.rotation = Quaternion.Euler(0, 0, 90);
            sprite.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (direction == "down")
        {
            dir = Vector3.down;
            sprite.transform.rotation = Quaternion.Euler(0, 0, 270);


        }
        if (direction == "left")
        {
            dir = Vector3.left;
            sprite.transform.rotation = Quaternion.Euler(0, 0, 180);


        }
        if (direction == "right")
        {
            dir = Vector3.right;
            sprite.transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(dir * Time.deltaTime * 10);
        if (Time.time - startTime > 3)
        {
            Destroy(gameObject);
        }

    }
}
