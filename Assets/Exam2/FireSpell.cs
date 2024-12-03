using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log("Casting a Fireball spell! Burn them all!");
    }
}
