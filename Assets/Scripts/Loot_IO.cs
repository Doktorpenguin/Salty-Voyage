using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_IO : MonoBehaviour
{
    public Enemy_Ship enemy_S;
    public Player_Controller pc;
    [Tooltip("Type 'Wood' for wood or 'Gunpowder' for gun powder.")]
    public string loot_type;
    //How much WILL they
    public int amount;
    //How much CAN they get?
    public int amountMax;
    public int amountMin;
    void Start()
    {
        enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

        if (amount == 0 && amountMax == 0)
        {
            amount = Random.Range(5, 15);
        }

        else
        {
            amount = Random.Range(amountMin, amountMax);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Take()
    {
        if (loot_type == "wood" || loot_type == "Wood")
        {
            if (enemy_S.Wood <= 0)
            {
                Debug.Log("Enemy has no wood to take");
                Destroy(this.gameObject);
            }

            else
            {

                enemy_S.Wood -= amount;
                pc.Wood += amount;

                Destroy(this.gameObject);
                //Play sound effect
            }
        }

        else if (loot_type == "Gunpowder" || loot_type == "gunpowder")
        {
            if (enemy_S.Ammo <= 0)
            {
                Debug.Log("Enemy has no ammo to take");
                Destroy(this.gameObject);
            }

            else
            {

                enemy_S.Ammo -= amount;
                pc.Ammo += amount;

                Destroy(this.gameObject);
                //Play sound effect
            }

        }

        else
        {

            Debug.Log("Either you typed in the 'loot_type' wrong or the 'loot_type' field is blank!");

        }

    }
}
