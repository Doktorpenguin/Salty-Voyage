using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    protected State State;

    public void setState(State state)
    {

        State = state;
        StartCoroutine(State.Start());

    }
}
