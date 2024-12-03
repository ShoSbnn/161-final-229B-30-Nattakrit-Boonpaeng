using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumtion = 0f;
    private int activityLevel =0;

    private void Start()
    {
        Init("Dog");
    }

    public override float CalculateFoodRequirement()
    {
        = dailyFoodConsumtion * activityLevel * 7;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName}: Hong Hong!");
    }
}

