﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Stats : MonoBehaviour
{

    public Cannon_Controller cc;
    public Cannon cannon;
    public bool needsReload;
    public Sprite cannonSprite;
    public Sprite activeSprite;

    void Start()
    {
        cannonSprite = cannon.cannonSprite;
        activeSprite = cannon.activeSprite;

        needsReload = false;

    }

    
    void Update()
    {
     
        

    }

    public void Reload()
    {
        if (cc.focusedCannon = null)
        {

           needsReload = false;
           cc.focusedCannon = this.gameObject;

        }

        else
        {
            needsReload = false;
        }

    }
}
