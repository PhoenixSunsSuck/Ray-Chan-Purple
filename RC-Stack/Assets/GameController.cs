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


    // Update is called once per frame
    void Update()
    {
        
    }
}
