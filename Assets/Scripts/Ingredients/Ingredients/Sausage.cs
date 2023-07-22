using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sausage : Ingredient
{
    public Sausage()
    {
        name = "Sausage";
        cost = 6;
        cookTime = 12;
        cookstate = Cookstate.RAW;
        RawSprite = Resources.Load<Sprite>("Sprites/Sausage_Raw");
        CookedSprite = Resources.Load<Sprite>("Sprites/Sausage_Cooked");
    }
}
