using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MealComponenet 
{
    public MealComponenet(Ingredients ingredient, Ingredient.Cookstate cook)
    {
        this.ingredient = ingredient;
        this.cookstate = cook;
    }

    public Ingredients ingredient;
    public Ingredient.Cookstate cookstate;
}