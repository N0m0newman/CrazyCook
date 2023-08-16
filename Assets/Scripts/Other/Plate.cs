using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public Dictionary<Ingredients, int> expectedOrder = new Dictionary<Ingredients, int>();

    ArrayList interacting = new ArrayList();

    private BoxCollider2D collider;

    public void resetPlate()
    {
        expectedOrder = null;
        expectedOrder = new Dictionary<Ingredients, int>();
        foreach(GameObject a in interacting)
        {
            Destroy(a);
        }
        expectedOrder.Add(Ingredients.BACON, 0);
        expectedOrder.Add(Ingredients.SAUSAGE, 0);
        expectedOrder.Add(Ingredients.TOAST, 0);
        expectedOrder.Add(Ingredients.EGG, 0);
    }

    private void Awake()
    {
        collider = GetComponent<BoxCollider2D>();
        expectedOrder.Add(Ingredients.BACON, 0);
        expectedOrder.Add(Ingredients.SAUSAGE, 0);
        expectedOrder.Add(Ingredients.TOAST, 0);
        expectedOrder.Add(Ingredients.EGG, 0);
    }

/*    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    IngredientObject e = collision.gameObject.GetComponent<IngredientObject>();
    //    interacting.Add(collision.gameObject);
    //    e.isDragging = false;
    //    e.isGrabbable = false;
    //    if(expectedOrder.ContainsKey(e.ingredients))
    //    {
    //        expectedOrder[e.ingredients] += 1;
    //    } else
    //    {
    //        expectedOrder.Add(e.ingredients, 1);
    //    }
    //}*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        IngredientObject e = collision.gameObject.GetComponent<IngredientObject>();
        if (e == null) return;
        if (e.isDragging) return;
        e.transform.position = collider.bounds.center;
        interacting.Add(collision.gameObject);
        e.isDragging = false;
        e.isGrabbable = false;
        if (expectedOrder.ContainsKey(e.ingredients))
        {
            expectedOrder[e.ingredients] += 1;
        }
        else
        {
            expectedOrder.Add(e.ingredients, 1);
        }
    }
}
