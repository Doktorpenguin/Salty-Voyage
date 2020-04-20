using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public Player_Controller pc;
    public Text woodText;
    public Text shipText;
   // public Text threadText;
    //public Text crewText;
    public Text goldText;
    public Text ammoText;
    public Text wbText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        woodText.text = "Wood =" + " " + pc.Wood.ToString();
        shipText.text = "Ship Health:" + " " + pc.shipHealth + "/" + pc.shipHealthMax;
      //  threadText.text = "Thread =" + " " + pc.Thread.ToString();
        //crewText.text = "Crew =" + " " + pc.Crew.ToString();
        goldText.text = "Gold =" + " " + pc.Gold.ToString();
        ammoText.text = "Ammo:" + " " + pc.Ammo.ToString() + "/" + pc.maxAmmo;
        wbText.text = "Water Buckets =" + " " + pc.waterBucket.ToString();

    }
}
