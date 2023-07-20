using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beans : Ingredient
{
    public Beans()
    {
        name = "Baked Beans";
        cost = 3;
        cookstate = Cookstate.RAW;
    }
}
