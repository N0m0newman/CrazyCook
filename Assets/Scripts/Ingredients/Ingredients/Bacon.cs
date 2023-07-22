using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacon : Ingredient
{
    public Bacon()
    {
        name = "Bacon";
        cost = 3;
        cookstate = Cookstate.RAW;
        cookTime = 5;
        RawSprite = Resources.Load<Sprite>("Sprites/Bacon_Raw");
        CookedSprite = Resources.Load<Sprite>("Sprites/Bacon_Cooked");
    }
}
