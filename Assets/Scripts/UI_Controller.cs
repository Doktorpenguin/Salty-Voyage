using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public Resources_Controller rc;
    public Text woodText;
    public Text shipText;
    public Text threadText;
    public Text crewText;
    public Text goldText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        woodText.text = "Wood =" + " " + rc.Wood.ToString();
        shipText.text = "Ship Health:" + " " + rc.shipHealth + "/100";
        threadText.text = "Thread =" + " " + rc.Thread.ToString();
        crewText.text = "Crew =" + " " + rc.Crew.ToString();
        goldText.text = "Gold =" + " " + rc.Gold.ToString();

    }
}
