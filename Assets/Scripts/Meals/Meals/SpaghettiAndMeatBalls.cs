using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaghettiAndMeatBalls : Meal
{
    public SpaghettiAndMeatBalls()
    {
        name = "Spaghetti and Meatballs";
        SetupMeal();
    }

    public override void SetupMeal()
    {
        expectedIngredients = new Dictionary<MealComponenet, int>
        {
            {new MealComponenet(Ingredients.SPAGHETTI, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.MEATBALLS, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.PASTASAUCE, Ingredient.Cookstate.COOKED), 1 }
        };
    }

}
