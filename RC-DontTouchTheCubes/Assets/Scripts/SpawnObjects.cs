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

    // Update is called once per frame
    void Update()
    {
        //The next cube to be spawn will 
        // be based on the difficulty end
        spawn = difficulty * Time.deltaTime;
        //difficulty of the game is based of
        //speed of the game times 4
        difficulty = Time.deltaTime * 4f;
        //While loop for spawning cubes.
        //If the spawn time is greater
        //than 0
        while (spawn > 0)
        {
            //Spawn time minus 1
            spawn -= 1;
            //Random posiotion of the cubes on the x and z axis
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 30f);
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            //Random scale of the cubes on the x and z axis
            GameObject createObject = Instantiate(spawnCube, v3Pos, qRotation);
        }
    }
}
