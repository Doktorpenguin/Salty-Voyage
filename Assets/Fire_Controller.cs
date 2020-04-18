using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Controller : MonoBehaviour
{
    public float spreadChance;
    public int spreadDirection;
    public bool hasSpread;
    public Player_Controller pc;

    void Start()
    {
        pc.shipHealth -= 1;
        hasSpread = false;
        spreadChance = Random.Range(0, 2);
        spreadDirection = Random.Range(0, 4);
        StartCoroutine("Timer");

    }

    
    void Update()
    {
        
        //Raycast to check if sides are free of collisions.

    }

    private void Spread(Vector3 direction)
    {

        Instantiate(this.gameObject, direction, this.transform.rotation);
        Debug.Log("Fire Spreads");

    }

    IEnumerator Timer()
    {
        if (spreadChance == 1 && hasSpread == false)
        {
            yield return new WaitForSeconds(5f);
            switch (spreadDirection)
            {

                case 0:
                    Spread(new Vector3(this.transform.position.x, this.transform.position.y + 1));
                    break;

                case 1:
                    Spread(new Vector3(this.transform.position.x, this.transform.position.y - 1));
                    break;

                case 2:
                    Spread(new Vector3(this.transform.position.x + 1, this.transform.position.y));
                    break;

                case 3:
                    Spread(new Vector3(this.transform.position.x - 1, this.transform.position.y));
                    break;

                default:
                    Spread(new Vector3(this.transform.position.x - 1, this.transform.position.y));
                    break;
            }
            spreadChance = Random.Range(0, 2);
            hasSpread = true;
        }

        else
        {
            spreadChance = Random.Range(0, 2);
            Debug.Log("Re-rolled to " + spreadChance);
            StartCoroutine("Timer");
        }
        //Spread(transform.);

    }
}
