using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //jumping power for the player object
    [Header("Default Jumping Power")]
    public float jumpPower = 6f;
    //True or false if the object
    //Is on the ground
    [Header("Boolean isGrounded")]
    public bool isGrounded = false;
    //Position of the object
    float posX = 0.0f;
    //Rb2d of the object
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //Var rb equals to Rb2d
        //component
        rb = transform.GetComponent<Rigidbody2D>();
        //Var posX equals to position
        //Of the object on the x axis
        posX = transform.position.x;
    }
    void FixedUpdate()
    {
        //If spacebar pressed and
        //object is on the ground and
        //the game is playing
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            //Adds force to the object
            //to jump upwards based on
            //jump power, mass, and
            //gravity
            rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 20.0f));
            //If the players position is less than
            //the original of the player
            if (transform.position.x < posX)
            {
                //Execute GameOver function
                GameOver();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //If colliders tag equals ground
        if (collision.collider.tag == "Ground")
        {
            //isGrounded = true
            isGrounded = true;
        }
        //If colliders tag equals enemy
        if (collision.collider.tag == "Enemy")
        {
            //Game OVer function is called
            GameOver();
        }
        //If triggers tag equals coin
        if (collision.collider.tag == "Coin")
        {
            //Call IncrementScore from
            //Game Controller
            GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();
            //Destroy Object
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //if colliders tag equals ground
        if(collision.collider.tag == "Ground")
        {
            //isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        //if colliders tag equals aroumnd
        if (collision.collider.tag == "Ground")
        {
            //isGrounded = false;
            isGrounded = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    //Game over function
    void GameOver()
    {
        //Game over function is called from the game manager
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If triggers tag equals coin
        if(collision.tag == "Coin")
        {
            //Destroy object
            Destroy(collision.gameObject);
        }
    }
}
