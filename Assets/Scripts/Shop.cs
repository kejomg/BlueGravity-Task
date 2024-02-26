using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<Item> items = new();
    public GameObject ItemShopPrefab;
    void Start()
    {
        GenerateShop(15);
    }

    void GenerateShop(int amount)
    {

    }
}
