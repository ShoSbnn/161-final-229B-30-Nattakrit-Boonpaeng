using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast() 
    {
        Debug.Log("Spell-Casting Simulation Started!");
        Debug.Log("Casting a generic spell!");
    }
}
