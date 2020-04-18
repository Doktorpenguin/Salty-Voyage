using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Blank_Crew", menuName = "Create Crew")]
public class Crew_Creator : ScriptableObject
{

    public string crewName;
    public Sprite crewSprite;

    public int maxHealth;
    public int currentHealth;
    public int moveSpeed;
    public int reloadSpeed;
    public int repairSpeed;
    public int damage;

}
