using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YaiYaiSpell : Spell
{
    public override void Cast()
    {
        Debug.Log($"Casting a YaiYaiSpell make user bigger!!!");
    }
    public void Cast(string me, int level , int power)
    {
        Debug.Log($"{me} grow bigger!! Now my level is {level} and my power is {power}!!!");
    }
    public void Start()
    {
        Cast();
        Cast("ME");
        Cast("ME", 99999);
        Cast("Me", 99999, 99999);
    }
}
