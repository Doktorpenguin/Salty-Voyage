using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Crew_Manager : StateMachine
{
    public bool job_Repair;
    void Start()
    {

        job_Repair = true;

    }

    
    void Update()
    {
        
        if (job_Repair)
        {
            StartCoroutine(State.Repair());
        }    

    }
}
