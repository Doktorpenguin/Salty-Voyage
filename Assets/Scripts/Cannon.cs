using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cannon", menuName = "Create Cannon")]
public class Cannon : ScriptableObject
{

    public int damage;
    public float reloadSpeed;
    public float accuracy;
    //the maximum amount of crew members that can operate the cannon.
    public float maxCrew;
    //ammo type variable
    public Sprite cannonSprite;
    public Sprite activeSprite;
    public Sprite cannonBallSprite;

}
