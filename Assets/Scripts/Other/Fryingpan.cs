using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fryingpan : MonoBehaviour
{
    public float countdownTime = 5f;
    public bool isCooking = false;
    public bool readyToCook = true;

    public GameObject cookingObject;
    IngredientObject ingredientObject;

    [SerializeField]
    public TextMeshPro CookingTimer;


    private CircleCollider2D collider; 

    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
    }

    public void startCooking()
    {
        isCooking = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!readyToCook) return;
        ingredientObject = collision.gameObject.GetComponent<IngredientObject>();
        if (ingredientObject.ingredient.cookstate == Ingredient.Cookstate.RAW && !ingredientObject.isDragging)
        {
            //Item left on pan should start cooking
            ingredientObject.transform.position = collider.bounds.center;
            readyToCook = false;
            ingredientObject.ingredient.cookstate = Ingredient.Cookstate.COOKING;
            countdownTime = ingredientObject.ingredient.cookTime;
            CookingTimer.gameObject.SetActive(true);
            CookingTimer.text = ingredientObject.ingredient.cookTime.ToString();
            ingredientObject.isDragging = false;
            ingredientObject.isGrabbable = false;
            isCooking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!readyToCook && !isCooking)
        {
            readyToCook = true;
            countdownTime = 0;
            CookingTimer.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(isCooking)
        {
            if(countdownTime > 0)
            {
                countdownTime -= Time.deltaTime;
                CookingTimer.text = FormatTime(countdownTime);
            } else
            {
                countdownTime = 0;
                CookingTimer.text = "Cooked!";
                isCooking = false;
                ingredientObject.isGrabbable = true;
                ingredientObject.ingredient.cookstate = Ingredient.Cookstate.COOKED;
                ingredientObject.ChangeToCooked();
                cookingObject = null;
                ingredientObject = null;
            }
        }
    }

    string FormatTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float sec = Mathf.FloorToInt(timeToDisplay % 60);
        return string.Format("{0:00}:{1:00}", minutes, sec);
    }
}
