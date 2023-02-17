using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox_ai_movement : MonoBehaviour


{
    [SerializeField]
    public GameObject up;

    [SerializeField]
    public GameObject down;

    [SerializeField]
    public GameObject left;

    [SerializeField]
    public GameObject right;


    public GameObject target_chicken;

    private string selfDirection = "up";


    private Animator animator;






    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        // up.SetActive(true);
        // down.SetActive(false);
        // right.SetActive(false);
        // left.SetActive(false);
    }

    // Update is called once per frame
    void Update()

    {
        if (target_chicken == null)
        {
            target_chicken = GameObject.Find("player chicken");
        }
        // fox moves towards player chicken to make fox run away from player -0.01f
        transform.position = Vector3.MoveTowards(transform.position, target_chicken.transform.position, 0.005f);

        // check fox's selfDirection
        if (transform.position.x < target_chicken.transform.position.x)
        {
            selfDirection = "right";
            animator.SetTrigger("move_right");

        }
        if (transform.position.x > target_chicken.transform.position.x)
        {
            selfDirection = "left";
            animator.SetTrigger("move_left");
        }
        if (transform.position.x == target_chicken.transform.position.x)
        {
            selfDirection = "up";
            animator.SetTrigger("move_up");
        }
        if (transform.position.y > target_chicken.transform.position.y)
        {
            selfDirection = "down";
            animator.SetTrigger("move_down");
        }


        // fox shows fox_up sprite when moving up

        // if (selfDirection == "up")
        // {
        //     up.SetActive(true);
        //     down.SetActive(false);
        //     left.SetActive(false);
        //     right.SetActive(false);
        // }
        // // fox shows fox_down sprite when moving down
        // if (selfDirection == "down")
        // {
        //     up.SetActive(false);
        //     down.SetActive(true);
        //     left.SetActive(false);
        //     right.SetActive(false);

        // }
        // // fox shows fox_side sprite when moving 
        // if (selfDirection == "right")
        // {
        //     up.SetActive(false);
        //     down.SetActive(false);
        //     right.SetActive(true);
        //     left.SetActive(false);

        // }
        // if (selfDirection == "left")
        // {
        //     up.SetActive(false);
        //     down.SetActive(false);
        //     right.SetActive(false);
        //     left.SetActive(true);
        // }
    }


}