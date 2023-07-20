using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : Ingredient
{

    public enum BreadForms
    {
        RAW,
        RAW_TOAST,
        TOAST,
        RAW_BURGER_BUN,
        BURGER_BUN,
    }

    private BreadForms state;


    public Toast()
    {
        name = "Toast";
        cost = 1;
        cookstate = Cookstate.RAW;
        RawSprite = Resources.Load<Sprite>("Sprites/Toast_Raw");
        CookedSprite = Resources.Load<Sprite>("Sprites/Toast_Cooked");
    }

    public BreadForms GetBreadState() { return state; }
    public void SetBreadState(BreadForms update)
    {
        state = update;
    }

}
