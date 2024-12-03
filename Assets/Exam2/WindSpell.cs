using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log("Casting a Wind Tornado spell! Fill them in tonado!");
    }
}
