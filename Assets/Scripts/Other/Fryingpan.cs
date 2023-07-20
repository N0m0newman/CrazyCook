using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fryingpan : MonoBehaviour
{
    public float maxCookDown = 5f;
    public float countdownTime = 5f;
    public bool isCooking = false;
    public bool readyToCook = true;

    public GameObject cookingObject;
    IngredientObject ingredientObject;

    public void startCooking()
    {
        isCooking = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Collision");
        ingredientObject = collision.gameObject.GetComponent<IngredientObject>();
        if(ingredientObject.ingredient.cookstate == Ingredient.Cookstate.RAW)
        {
            readyToCook = false;
            ingredientObject.ingredient.cookstate = Ingredient.Cookstate.COOKING;
            ingredientObject.isDragging = false;
            ingredientObject.isGrabbable = false;
            isCooking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        readyToCook = true;
        countdownTime = maxCookDown;
    }

    void Update()
    {
        if(isCooking)
        {
            if(countdownTime > 0)
            {
                UnityEngine.Debug.Log(Mathf.FloorToInt(countdownTime % 60));
                countdownTime -= Time.deltaTime;
            } else
            {
                UnityEngine.Debug.Log("Cooked!");
                countdownTime = 0;
                isCooking = false;
                ingredientObject.isGrabbable = true;
                ingredientObject.ingredient.cookstate = Ingredient.Cookstate.COOKED;
                ingredientObject.ChangeToCooked();
                cookingObject = null;
                ingredientObject = null;
            }
        }
    }
}
