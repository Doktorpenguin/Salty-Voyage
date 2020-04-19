using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy_Hole_Event : MonoBehaviour
{
    public GameObject enemy_Ship;
    void Start()
    {
        enemy_Ship = GameObject.FindGameObjectWithTag("Enemy Ship");
        enemy_Ship.GetComponent<Enemy_Ship>().shipHealth -= 5;

    }

    
    void Update()
    {
        


    }

}
