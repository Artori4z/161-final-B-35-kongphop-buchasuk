using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 0.5f;
    private int activityLevel = 2;
    public override float CalculateFoodRequirement()
    {
        float FoodRequirement = (dailyFoodConsumption) * (activityLevel) * 7;
        return FoodRequirement;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} barks: Woof!!");
    }
    public void Start()
    {
        Init("Dog");
        DisplayName();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} Kg of daily with activity Level {activityLevel}");
        Debug.Log($"Dog weekly food requirement:{CalculateFoodRequirement()} Kg.");

    }
}
