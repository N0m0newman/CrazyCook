using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeefBurger : Ingredient
{
    public BeefBurger()
    {
        name = "Beef Burger";
        cost = 5;
        cookstate = Cookstate.RAW;
    }
}
