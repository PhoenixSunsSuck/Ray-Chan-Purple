using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    //Cube that is going to be spawned
    public GameObject spawnCube;
    //difficulty of the game
    [Header("Default Difficulaty")]
    public float difficulty = 40f;
    //Time for the next cube
    //to be spawned.
    float spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
