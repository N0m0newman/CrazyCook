using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Meal
{

    protected  Dictionary<MealComponenet, int> ingredients;
    protected Dictionary<MealComponenet, int> expectedIngredients;
    protected string name;
    protected int MoneyEarned;

    public string getName()
    {
        return name;
    }

    public Dictionary<MealComponenet, int> getExpectedIngredients()
    {
        return expectedIngredients;
    }

    public Dictionary<MealComponenet, int> getSuppliedIngredients()
    {
        return ingredients;
    }

    public virtual void SetupMeal() { }

    public virtual void SetupCustomMeal(Dictionary<MealComponenet, int> customMealList)
    {
        expectedIngredients = customMealList;
    }
}
