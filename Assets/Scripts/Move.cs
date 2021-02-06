using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject Ground;
    private Rigidbody2D rb;      //Reference to Rigidbody Component
    public float speed;        //Speed, updated through script
    public float acceleration; //Every second, the speed will increase by this much
    public GameObject deadScreen;
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

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed +1f, 0f, 0f) * Time.deltaTime;
          

        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;
       

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;


        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -speed, 0f) * Time.deltaTime;


        }

        //Add acceleration to speed, make sure it's not above topSpeed)
        speed += Time.deltaTime * acceleration;
        //Set object velocity
        rb.velocity = -transform.forward * speed;




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Spike")
        {
            Destroy(this.gameObject);
            deadScreen.SetActive(true);
            Time.timeScale = 0;
        }


    }
}
