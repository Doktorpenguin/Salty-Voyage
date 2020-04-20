using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairing_State : State
{
    public GameObject damage;

    public Repairing_State(Enemy_Ship enemy_S) : base(enemy_S)
    {
    }
    public Repairing_State(GameObject crew) : base(crew)
    {
    }

    public override IEnumerator Start()
    {
        Crew.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;

        if (damage != null)
        {
            Enemy_S.shipHealth -= 1;
            Crew.transform.position = Vector2.MoveTowards(Crew.transform.position, damage.transform.position, Crew.GetComponent<Enemy_Crew_Manager>().speed * Time.deltaTime);

        }

        Debug.Log("WAAAAAAAAA");
        return base.Start();

    }


}
