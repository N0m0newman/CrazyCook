using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientObject : MonoBehaviour
{
    //base ingredient that is created in Contianer
    [SerializeField]
    public Ingredient ingredient;
    public SpriteRenderer spriteRenderer;

    //grab and drag vars
    public bool isDragging = false;
    public bool isGrabbable = true;
    public Ingredients ingredients;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UnityEngine.Debug.Log(spriteRenderer);
        UnityEngine.Debug.Log(ingredient);
        spriteRenderer.sprite = ingredient.RawSprite;
    }

    public void Setup()
    {
        spriteRenderer.sprite = ingredient.RawSprite;
    }

    public void ChangeToCooked()
    {
        spriteRenderer.sprite = ingredient.CookedSprite;
    }
    //start drag
    private void OnMouseDown()
    {
        if(isGrabbable) isDragging = true;
    }
    //end drag
    private void OnMouseUp()
    {
        isDragging = false;
    }
    //update object to mouse
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

}
