using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public Ingredient ingredient;
    [SerializeField]
    public GameObject prefabIngredient;

    private Vector3 location;


    [SerializeField]
    public Ingredients containerIngredients;

    private void OnMouseDown()
    {
        location = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        location.x = -4.15f;
        location.z = 0;
        GameObject e = Instantiate(prefabIngredient, location, Quaternion.identity);
        IngredientObject a = e.GetComponent<IngredientObject>();
        switch (containerIngredients)
        {
            case Ingredients.BACON:
                ingredient = new Bacon();
                a.ingredient = ingredient;
                a.ingredients = Ingredients.BACON;
                Shop.instance.SetCoins(Shop.instance.GetCoins() - a.ingredient.cost);
                a.Setup();
                break;
            case Ingredients.TOAST:
                ingredient = new Toast();
                a.ingredient = ingredient;
                a.ingredients = Ingredients.TOAST;
                Shop.instance.SetCoins(Shop.instance.GetCoins() - a.ingredient.cost);
                a.Setup();
                break;
            case Ingredients.EGG:
                ingredient = new Egg();
                a.ingredient = ingredient;
                a.ingredients = Ingredients.EGG;
                Shop.instance.SetCoins(Shop.instance.GetCoins() - a.ingredient.cost);
                a.Setup();
                break;
            case Ingredients.SAUSAGE:
                ingredient = new Sausage();
                a.ingredient = ingredient;
                a.ingredients = Ingredients.SAUSAGE;
                Shop.instance.SetCoins(Shop.instance.GetCoins() - a.ingredient.cost);
                a.Setup();
                break;
        }
    }
}
