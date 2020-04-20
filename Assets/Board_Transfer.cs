using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Board_Transfer : MonoBehaviour
{
    public int Test;
    void Start()
    {

        Debug.Log(Test);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnOverworld ()
    {

        SceneManager.LoadScene(0);

    }
}
