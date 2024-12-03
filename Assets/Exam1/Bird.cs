using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumtion;
    private float weight;

    private void Start()
    {
        Init("Bird");
    }
    public override float CalculateFoodRequirement()
    {
        dailyFoodConsumtion * weight * 7;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName}: Jib Jib!");
    }
}
