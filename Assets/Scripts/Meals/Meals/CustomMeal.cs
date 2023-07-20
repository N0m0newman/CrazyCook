using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMeal : Meal
{
    public CustomMeal(string _name, Dictionary<MealComponenet, int> meal)
    {
        name = _name;
        SetupCustomMeal(meal);
    }
}
