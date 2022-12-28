using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //RigidBody2D object that is stored
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    //downward speed of the object 
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //movement direction of the object
    public float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //variable equals to component RigidBody2D 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement equals Horizontal movement
        //multiplied by the movement speed 
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //If direction on x axis is less than 0
        if (movement < 0)
        {
            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        
    }
    //fixedupdate called every fixed frame-rate frame.
    private void FixedUpdate()
    {
        //vector2 which is (x,y) velocity
        //equals to the velocity of the Rigidbody2d
        Vector2 velocity = rb.velocity;
        //Velocity of the x axis equals to
        //the direction movement on the x axis
        //of the character
        velocity.x = movement;
        //rigidbody2d
        //velocity of the object
        rb.velocity = velocity;
    }
    //Collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //velocity with the downspeed 
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
    }
}