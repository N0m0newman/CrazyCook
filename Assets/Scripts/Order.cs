using System;
using System.Collections;
using UnityEngine;

public class Order
{
    private bool Failed;
    private ArrayList meals;
    public Order(int mealsOnOrder)
    {
        meals = new ArrayList();
        for(int i = 0; i < mealsOnOrder; i++)
        {
            int mealsIndex = UnityEngine.Random.Range(1, 4);
            meals.Add((Meals)mealsIndex);
            
        }
    }

    public ArrayList GetMealsInOrder()
    {
        return meals;
    }

    public bool DidFailOrder()
    {
        return Failed;
    }
}
