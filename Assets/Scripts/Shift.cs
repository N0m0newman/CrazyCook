using System.Collections;
using UnityEngine;
public class Shift : MonoBehaviour
{
    private int TotalOrders;
    private int CoinsEarned;

    private int OrdersCompleted;
    private int OrdersFailed;

    private ArrayList OrderQueue;

    public Shift(int minimumOrders ,int maxOrders, int maxMealsInOrder)
    {
        TotalOrders = 0;
        CoinsEarned = 0;
        OrdersCompleted = 0;
        OrdersFailed = 0;
        TotalOrders = Random.Range(minimumOrders, maxOrders);
        for (int i = 1; i < TotalOrders; i++)
        {
            int t = Random.Range(1, maxMealsInOrder);
            Order order = new Order(t);
            OrderQueue.Add(order);
        }
    }

    public int GetTotalOrders()
    {
        return TotalOrders;
    }

    public int GetCoinsEarned()
    {
        return CoinsEarned;
    }

    public void FinishOrder(bool didFail, int CoinsEarned, Order order)
    {
        if(!didFail)
        {

        }
    }

    public int GetordersCompleted()
    {
        return OrdersCompleted;
    }

    public int GetOrdersFailed()
    {
        return OrdersFailed;
    }

}
