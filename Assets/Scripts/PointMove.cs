using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointMove : MonoBehaviour
{

    public GameObject Ground;
    private Rigidbody2D rb;      //Reference to Rigidbody Component
    public float speed;        //Speed, updated through script
    public float acceleration; //Every second, the speed will increase by this much
    static int score = 0;
    public bool isMoving = false;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.forward * speed;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(speed + 1f, 0f, 0f) * Time.deltaTime;
        }

        else if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;
        }

        else if (Input.GetKey("down"))
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

        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            score++;
            text.text = "Score: " + score;
            Debug.Log("Score: " + score);
        }


    }
}
