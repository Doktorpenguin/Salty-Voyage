using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public Resources_Controller rc;
    public Text woodText;
    public Text shipText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        woodText.text = "Wood =" + " " + rc.Wood.ToString();
        shipText.text = "Ship Health:" + " " + rc.shipHealth + "/100";
    }
}
