using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Stats : MonoBehaviour
{

    public Cannon cannon;
    public bool needsReload;
    public Sprite cannonSprite;
    public Sprite activeSprite;
    public Sprite cannonBallSprite;

    void Start()
    {
        cannonSprite = cannon.cannonSprite;
        activeSprite = cannon.activeSprite;
        cannonBallSprite = cannon.cannonBallSprite;

        needsReload = false;

    }

    
    void Update()
    {
     
        

    }
}
