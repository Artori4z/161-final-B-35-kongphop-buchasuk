using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log($"Casting a Ice wall!! enemy Blocked!");
    }
    public void Start()
    {
        Cast();
        Cast("Normal Guys");
        Cast("Normal Guys", 1);
    }
}
