using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Debug_Controller : MonoBehaviour
{
    // This script is purely for debugging, it's used to incite events for testing and debug purposes. this script should be disabled before the final release of the game.
    //public Sprite holeTile;
    public Tilemap tm;
    public TileBase leakT;
    public GameObject leak;
    void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 pos = Input.mousePosition;
            Vector3Int tilePos = tm.WorldToCell(Camera.main.ScreenToWorldPoint(pos));
            //GameObject leakObj = Instantiate(leak, tilePos, this.transform.rotation);
            //leakObj.transform.position = new Vector3 (leakObj.transform.position.x, leakObj.transform.position.y, 0);
            tilePos.z = 0;
            tm.SetTile(tilePos, leakT);

        }
    }

}
