using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell Casting Simulation");
        Debug.Log($"Casting a nah Spell!");
    }
    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}");
    }
    public void Cast(string target, int level) 
    {
        Debug.Log($"Casting a spell on {target} with power level:{level}");
    }
}
