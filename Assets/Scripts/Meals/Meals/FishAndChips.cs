using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAndChips : Meal
{
    public FishAndChips()
    {
        name = "Fish and Chips";
        SetupMeal();
    }

    public override void SetupMeal()
    {
        expectedIngredients = new Dictionary<MealComponenet, int>
        {
            {new MealComponenet(Ingredients.FISH, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.CHIPS, Ingredient.Cookstate.COOKED), 1 }
        };
    }
}
