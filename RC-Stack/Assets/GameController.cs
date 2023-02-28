using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//User interface namespace
using UnityEngine.UI;
//Scene management namespace
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Current cube game object
    [Header("Cube Object")]
    public GameObject currentCube;
    //Last cube game object
    [Header("Last Cube Object")]
    public GameObject lastCube;
    //Text object
    [Header("Text object")]
    public Text text;
    //Level number interger
    [Header("Current level")]
    public int Level;
    //Boolean determining if game
    //is over
    [Header("Boolean")]
    public bool Done;
    // Start is called before the first frame update
    void Start()
    {

    }

    void NewBlock()
    {
        if (lastCube != null)
        {
            //The current cube position equals to all 3 axis positions
            //to the nearest integer
            currentCube.transform.position =
            new Vector3(Mathf.Round(currentCube.transform.position.x),
                currentCube.transform.position.y);
            Mathf.Round(currentCube.transform.position.z);
            //current cubes size equals to the last cube size
            currentCube.transform.localScale =
                new Vector3(lastCube.transform.localScale.x -
                    Mathf.Abs(currentCube.transform.position.x -
                    lastCube.transform.position.x),
                    lastCube.transform.localScale.y,
                    lastCube.transform.localScale.z -
                    Mathf.Abs(currentCube.transform.position.z -
                    lastCube.transform.position.z));
            //current cubes positions equals to te current cubes x position
            //last cubes y position
            //z axis position of 0.5
            currentCube.transform.position =
                Vector3.Lerp(currentCube.transform.position, lastCube.transform.
                position, 0.5f) + Vector3.up * 5f;
        }
        //if the current cube size on x axis is less than or equal to 0 or if the current cube size on the z axis is less than or equal to 0
        if(currentCube.transform.localScale.x <= 0f || 
            currentCube.transform.localScale.z <= 0f)
        {
            //Done equals to true
            Done = true;
            //Text is visible
            text.gameObject.SetActive(true);
            //Text equals to the tect of the Final Score
            //and which level is played
            text.text = "Final Score:" + Level;
            //Start Corountine function X
            StartCoroutine(X());
            //Returns value
            return;
            //Last  cube equals to the current cube
            lastCube = currentCube;
            //Current cube equals to the spawned last Cube
            currentCube = Instantiate(lastCube);
            //Current cube equals to the spawned
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
