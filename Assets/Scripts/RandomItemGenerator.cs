using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomItemGenerator : MonoBehaviour
{
    public List<String> adjectives = new ();
    public List<Sprite> headSprites = new();
    public List<Sprite> faceSprites = new();
    public List<Sprite> armorSprites = new();
    public List<Sprite> pantsSprites = new();
    public List<Sprite> daggerSprites = new();
    public List<Sprite> daggerShopSprites = new();

    public string GetRandomAdjective()
    {
        return adjectives[UnityEngine.Random.Range(0, adjectives.Count)].ToString();
    }

    public void GetRandomSprite(ref Item item)
    {
        switch (item.itemSlot)
        {
            case ItemSlot.Headgear:
                item.itemIcon = headSprites[UnityEngine.Random.Range(0, headSprites.Count)];
                break;
            case ItemSlot.Face:
                item.itemIcon = faceSprites[UnityEngine.Random.Range(0, faceSprites.Count)];
                break;
            case ItemSlot.Armor:
                item.itemIcon = armorSprites[UnityEngine.Random.Range(0, armorSprites.Count)];
                break;
            case ItemSlot.Pants:
                item.itemIcon = pantsSprites[UnityEngine.Random.Range(0, pantsSprites.Count)];
                break;
            case ItemSlot.Dagger:
                item.itemIcon = daggerShopSprites[UnityEngine.Random.Range(0, daggerShopSprites.Count)];
                break;
            case ItemSlot.COUNT:
                break;
        }
    }

    public Sprite GetRandomSpritee(ItemSlot slot)
    {
        switch (slot)
        {
            case ItemSlot.Headgear:
                return headSprites[UnityEngine.Random.Range(0, headSprites.Count)];
            case ItemSlot.Face:
                return faceSprites[UnityEngine.Random.Range(0, faceSprites.Count)];
            case ItemSlot.Armor:
                return armorSprites[UnityEngine.Random.Range(0, armorSprites.Count)];
            case ItemSlot.Pants:
                return pantsSprites[UnityEngine.Random.Range(0, pantsSprites.Count)];
            case ItemSlot.Dagger:
                return daggerShopSprites[UnityEngine.Random.Range(0, daggerShopSprites.Count)];
            case ItemSlot.COUNT:
                return null;
        }
        return null;
    }

    public void GenerateRandomItem(ref Item item)
    {
        GetRandomSlot(ref item);
        GetRandomQuality(ref item);
        GetRandomSprite(ref item);
    }

    public void GetRandomSlot(ref Item item)
    {
        item.itemSlot = (ItemSlot)UnityEngine.Random.Range(0, (float)ItemSlot.COUNT);
    }

    public void GetRandomQuality(ref Item item)
    {
        item.itemName = GetRandomAdjective() + " " + item.itemSlot;
        item.itemPrice = UnityEngine.Random.Range(100, 2000);
    }
}
