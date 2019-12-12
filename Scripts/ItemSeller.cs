using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSeller : MonoBehaviour
{

    private Item SoldItem;
    public float AmountToSell;
    private PlayerInventory Inventory;


    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("Canvas").GetComponent<PlayerInventory>();
        SoldItem = GetComponentInParent<Item>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SellItem()
    {
        Inventory.SellItem(SoldItem);

    }
}
