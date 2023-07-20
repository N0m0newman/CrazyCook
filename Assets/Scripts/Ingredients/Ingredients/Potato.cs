using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : Ingredient
{
    public enum PotatoState
    {
        RAW,
        CHIPS,
        HASHBROWN
    }

    private PotatoState state;

    public Potato()
    {
        name = "Potato";
        cost = 4;
        state = PotatoState.RAW;
        cookstate = Cookstate.RAW;
    }

    public PotatoState GetPotatoState() { return state; }
    public void SetPotatoState(PotatoState update)
    {
        state = update;
    }

}
