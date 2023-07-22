using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    //Singleton instance
    public static Shop instance;


    //Get UI Text Elements for updating
    [SerializeField]
    public TextMeshProUGUI goldCoinAmount;
    [SerializeField]
    public TextMeshPro mealComponents;
    [SerializeField]
    public Plate plate;

    public int customersServed = 0;

    //Ending screen
    [SerializeField]
    public TextMeshProUGUI Title;
    [SerializeField]
    public TextMeshProUGUI customers;
    [SerializeField]
    public GameObject endScreen;

    //Variable declaring
    private string shopName = "Shopping shop";
    private int shopCoins = 50;
    public Dictionary<Ingredient, int> shopIngredients;
    public Dictionary<Ingredients, int> expectedOrder;
    //create singleton and then setup first order and ui text
    private void Awake()
    {
        #region Singleton
        instance = this;
        #endregion  
        shopIngredients = new Dictionary<Ingredient, int>();
        goldCoinAmount.text = shopCoins.ToString();
        GenerateOrder();
    }


    public int GetCoins() { return shopCoins; }
    public void SetCoins(int newCoins)
    {
        shopCoins = newCoins;
        goldCoinAmount.text = shopCoins.ToString();
        if(shopCoins <= 0)
        {
            shopCoins = 0;
            Time.timeScale = 0;
            UnityEngine.Debug.Log("failed");
            Title.text = "You Failed!";
            customers.text = "Customers Served: " + customersServed;
            endScreen.SetActive(true);
        } 
    }
    //Reopen scene 
    public void RestartShift()
    {
        SceneManager.LoadScene(0);
    }
    //Hand in order checking the two dictonaries
    public void HandInOrder()
    {
        bool isSame = true;
        if(expectedOrder != null && plate.expectedOrder != null)
        {
            return;
        }
        foreach (var pair in expectedOrder)
        {
            int value;
            if (plate.expectedOrder.TryGetValue(pair.Key, out value))
            {
                if (value != pair.Value)
                {
                    isSame = false;
                    break;
                }
            }
            else
            {
                isSame = false;
                break;
            }
        }
        if (isSame)
        {
            SetCoins(shopCoins += 10);
            customersServed += 1;
            GenerateOrder();
            plate.resetPlate();
        }
        else
        {
            SetCoins(shopCoins -= 8);
            goldCoinAmount.text = shopCoins.ToString();
            GenerateOrder();
            plate.resetPlate();
        }
    }
    //randomly generate the order
    public void GenerateOrder()
    {
        expectedOrder = null;
        expectedOrder = new Dictionary<Ingredients, int>();
        //add each ingredient to dictionary
        expectedOrder.Add(Ingredients.BACON, GenerateAmount());
        expectedOrder.Add(Ingredients.SAUSAGE, GenerateAmount());
        expectedOrder.Add(Ingredients.TOAST, GenerateAmount());
        expectedOrder.Add(Ingredients.EGG, GenerateAmount());
        //create the string for the UI element
        string order = null;
        foreach(KeyValuePair<Ingredients, int> keyValuePair in expectedOrder)
        {
            Ingredients ingred = keyValuePair.Key;
            int amount = keyValuePair.Value;
            if (amount == 0) continue;
            order += amount.ToString() + "x " + ingred + "\n";
            order.Replace('\n', '\n');
            mealComponents.text = order;
        }

    }
    //generate number between 0-2
    private int GenerateAmount()
    {
        return Random.Range(0, 3);
    }

    public string GetShopName() { return shopName; }

}
