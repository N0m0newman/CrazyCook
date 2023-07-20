using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create Object oriented base class
[Serializable]
public abstract class Ingredient
{
    public string name;
    //create two sprites that it can swap between
    public Sprite CookedSprite;
    public Sprite RawSprite;
    public Cookstate cookstate;
    //cost of each ingredient
    public int cost;

    //Cookstate essential to stop same ingredient being cooked again
    public enum Cookstate
    {
        RAW,
        COOKING,
        COOKED,
        BURNT
    }

    public Cookstate GetCookState() { return cookstate; }
    public void UpdateCookState(Cookstate state) { cookstate = state; }
}
