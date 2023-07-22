using UnityEngine;

public class Egg : Ingredient
{
    public Egg()
    {
        name = "Egg";
        cost = 8;
        cookTime = 9;
        cookstate = Cookstate.RAW;
        RawSprite = Resources.Load<Sprite>("Sprites/Egg_Raw");
        CookedSprite = Resources.Load<Sprite>("Sprites/Egg_Cooked");
    }
}
