using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected Enemy_Ship Enemy_S;
    protected GameObject Crew;

    public State(Enemy_Ship enemy_S)
    {
        Enemy_S = enemy_S;
    }

    public State(GameObject crew)
    {
        Crew = crew;
    }

    public virtual IEnumerator Start()
    {

        yield break;

    }

    public virtual IEnumerator Repair()
    {

        yield break;

    }

    public virtual IEnumerator Defending()
    {

        yield break;

    }

    public virtual IEnumerator Boarding()
    {

        yield break;

    }

    public virtual IEnumerator cannons()
    {

        yield break;

    }
}
