using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting a Fireball!! Bure them!");
    }
    public void Start()
    {
        Cast();
        Cast("Monkey");
        Cast("Monkey", 3);
    }
}
