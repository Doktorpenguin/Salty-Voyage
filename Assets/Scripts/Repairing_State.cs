using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairing_State : State
{
    public GameObject damage;
    public Repairing_State(Enemy_Ship enemy_S) : base(enemy_S)
    {
    }

    private void Update ()
    {

        Debug.Log("WAAAAAAAAA");

    }
    

}
