using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    //After this time, the object will be destroyed
    [Header("Default Destruction Time")]
    public float timeToDestruction;
    // Start is called before the first frame update
    void Start()
    {
        //Execute DestroyObject function based on the timeToDestruction
        Invoke("DestroyObject", timeToDestruction);
    }
    void DestroyObject()
    {
        //Destroy object
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

