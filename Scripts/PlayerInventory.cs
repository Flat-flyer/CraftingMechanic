using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public Item TestItem;
    public Item TestItemTwo;
    private float PlayerCurrency = 0f;
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

        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void SellItem (Item item, float ReducedAmount)
    {

        if (item.ItemAmount > 0)
        {
            item.ItemAmount = item.ItemAmount - ReducedAmount;
            PlayerCurrency = PlayerCurrency + item.Value;
            DisplayedCurrency.text = "X " + PlayerCurrency;
            Debug.Log("Quantity of " + item.ItemName + " is " + item.ItemAmount);

        }
        else
        {
            item.ItemAmount = 0;
        }
    }
}
