using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : Ingredient
{
    public Cheese()
    {
        name = "Cheese";
        cost = 2;
        cookstate = Cookstate.COOKED;
    }
}
