using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public Item TestItem;
    public Item TestItemTwo;
    public Item Sword;
    public Item Pick;
    public float PlayerCurrency = 0f;
    public Text DisplayedCurrency;
    private SpritesList SpriteRef;
    

    // Start is called before the first frame update
    void Start()
    {
        SpriteRef = GameObject.Find("SpriteRef").GetComponent<SpritesList>();
        TestItem = GameObject.Find("TestItem").GetComponent<Item>();
        TestItem.ItemName = "Wood";
        TestItem.ItemMaxAmount = 99f;
        TestItem.ItemAmount = 0;
        TestItem.Value = 100f;
        TestItem.HQValue = 300f;
        TestItem.ItemImage = SpriteRef.Sprite[0];
        TestItemTwo = GameObject.Find("TestItem2").GetComponent<Item>();
        TestItemTwo.ItemName = "Iron Ingot";
        TestItemTwo.Value = 300f;
        TestItemTwo.HQValue = 500f;
        TestItemTwo.ItemImage = SpriteRef.Sprite[1];
        TestItemTwo.IsHighQuality = false;
        Sword = GameObject.Find("SwordItem").GetComponent<Item>();
        Sword.ItemName = "Wooden Sword";
        Sword.ItemMaxAmount = 10f;
        Sword.ItemAmount = 0f;
        Sword.Value = 750f;
        Sword.HQValue = 1500f;
        Sword.ItemImage = SpriteRef.Sprite[2];
        Sword.IsHighQuality = false;
        Pick = GameObject.Find("PickItem").GetComponent<Item>();
        Pick.ItemName = "Pickaxe";
        Pick.ItemMaxAmount = 10f;
        Pick.ItemAmount = 0f;
        Pick.Value = 900f;
        Pick.HQValue = 2000f;
        Pick.ItemImage = SpriteRef.Sprite[3];
        Pick.IsHighQuality = false;



    }

    // Update is called once per frame
    void Update()
    {
        DisplayedCurrency.text = "X " + PlayerCurrency;
    }

    public void AddQuantityToItem(Item item, float addedAmount)
    {
        item.ItemAmount = item.ItemAmount + addedAmount;

        if (item.ItemAmount > item.ItemMaxAmount)
        {
            item.ItemAmount = item.ItemMaxAmount;
        }
        Debug.Log("Quantity of " + item.ItemName + " is " + item.ItemAmount);
        Debug.Log("Quantity of " + TestItemTwo.ItemName + " is " + TestItemTwo.ItemAmount);
    }

    public void SellItem (Item item)
    {

        if (item.ItemAmount > 0)
        {
            RemoveItem(item, 1);
            PlayerCurrency = PlayerCurrency + item.Value;
            Debug.Log("Quantity of " + item.ItemName + " is " + item.ItemAmount);

        }
        else
        {
            item.ItemAmount = 0;
        }
    }

    public void RemoveItem (Item item, float AmountRemoved)
    {
        item.ItemAmount = item.ItemAmount - AmountRemoved;
    }

    public void RemoveGold (float GoldRemoved)
    {
        PlayerCurrency = PlayerCurrency - GoldRemoved;
    }
}
