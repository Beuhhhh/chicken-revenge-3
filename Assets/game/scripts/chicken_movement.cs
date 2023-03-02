using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class chicken_movement : MonoBehaviour

{
    [SerializeField]
    public GameObject up;

    [SerializeField]
    public GameObject down;

    [SerializeField]
    public GameObject side;

    [SerializeField]
    public GameObject bullet;



    public string direction = "up";

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            newBullet.GetComponent<bullet_movement>().shootBullet(direction);
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction = "up";
            transform.Translate(Vector3.up * Time.deltaTime * 3);
            up.SetActive(true);
            down.SetActive(false);
            side.SetActive(false);
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = "down";
            transform.Translate(Vector3.down * Time.deltaTime * 3);
            up.SetActive(false);
            side.SetActive(false);
            down.SetActive(true);
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = "left";
            transform.Translate(Vector3.left * Time.deltaTime * 3);
            up.SetActive(false);
            down.SetActive(false);
            side.SetActive(true);
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = "right";

            transform.Translate(Vector3.right * Time.deltaTime * 3);
            up.SetActive(false);
            down.SetActive(false);
            side.SetActive(true);
            transform.localScale = new Vector3(-3, 3, 3);
        }

    }


}
