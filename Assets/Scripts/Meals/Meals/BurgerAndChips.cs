using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerAndChips : Meal
{
    public BurgerAndChips()
    {
        name = "Burger and chips";
        SetupMeal();
    }

    public override void SetupMeal()
    {
        expectedIngredients = new Dictionary<MealComponenet, int>
        {
            {new MealComponenet(Ingredients.BURGER_BUN, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.BURGER, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.CHEESE, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.SALAD, Ingredient.Cookstate.COOKED), 1 },
            {new MealComponenet(Ingredients.CHIPS, Ingredient.Cookstate.COOKED), 1 }
        };
    }
}
