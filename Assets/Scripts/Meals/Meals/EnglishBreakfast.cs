using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnglishBreakfast : Meal
{
   public EnglishBreakfast()
    {
        name = "English Breakfast";
        
    }
    public override void SetupMeal()
    {
        expectedIngredients = new Dictionary<MealComponenet, int>
        {
            { new MealComponenet(Ingredients.EGG, Ingredient.Cookstate.COOKED), 2 },
            { new MealComponenet(Ingredients.BACON, Ingredient.Cookstate.COOKED), 3 },
            { new MealComponenet(Ingredients.SAUSAGE, Ingredient.Cookstate.COOKED), 2 },
            { new MealComponenet(Ingredients.HASHBROWN, Ingredient.Cookstate.COOKED), 2 },
            { new MealComponenet(Ingredients.TOAST, Ingredient.Cookstate.COOKED), 1 },
            { new MealComponenet(Ingredients.BEANS, Ingredient.Cookstate.COOKED), 1 }
        };
    }
}
