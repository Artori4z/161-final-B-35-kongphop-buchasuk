using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.4f;
    private float weight = 0.2f;
    public override float CalculateFoodRequirement()
    {
        float FoodRequirement = (dailyFoodConsumption) * weight * 7;
        return FoodRequirement;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} chirps: Tweet!!!");
    }

    public void Start()
    {
        Init("Bird");
        DisplayName();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} Kg of daily and weight {weight} Kg.");
        Debug.Log($"Dog weekly food requirement:{CalculateFoodRequirement()} Kg.");
    }
}
