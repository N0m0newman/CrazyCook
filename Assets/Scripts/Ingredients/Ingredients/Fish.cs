using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Ingredient
{
    public Fish()
    {
        name = "Fish";
        cost = 2;
        cookstate = Cookstate.RAW;
    }
}
