using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    [SerializeField]
    Shop shop;
    private void OnMouseDown()
    {
        shop.HandInOrder();
    }
}
