using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug :MonoBehaviour
{
    [SerializeField]
    public SpriteRenderer _sprite;

    public void OnMouseDown()
    {
        _sprite.sprite = Resources.Load<Sprite>("Sprites/Bacon_Raw");
    }


    public void GenerateOrder()
    { 
        Order order = new Order(3);
        order.GetMealsInOrder();
    }
}
