using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //Rigidbody for object
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //Shrinking speed
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //Rotation of the rb
        //at a random range
        rb.rotation = Random.Range(0f, 360f);
        //local scale for the hexagon
        //equals one for all axes times
        //ten
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //local scale equals for shrinking multiplied by
        //axis size multiplied by game rate
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        //local scale on x axis is less
        //or equals to .05
        if(transform.localScale.x <= .120f)
        {
            //Destroy object
            Destroy(gameObject);
            //Add 1 to score
            Score.score++;
        }
    }
}
