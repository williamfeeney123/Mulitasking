using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{

    public GameObject Ground;
    private Rigidbody2D rb;      //Reference to Rigidbody Component
    public float speed;        //Speed, updated through script
    public float acceleration; //Every second, the speed will increase by this much

    public bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.forward * speed;
    }
    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
        //Add acceleration to speed, make sure it's not above topSpeed)
        speed += Time.deltaTime * acceleration;
        //Set object velocity
        rb.velocity = -transform.forward * speed;



    
    }
}
