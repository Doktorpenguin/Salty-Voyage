using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_Event : MonoBehaviour
{
    public Resources_Controller RC;
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter(Collision other) {

        Debug.Log("Fafa");

        if (RC.Wood >= 5) 
        {
            Destroy(this);
            RC.Wood =- 5;
        }
    }
}
