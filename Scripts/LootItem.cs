using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootItem : MonoBehaviour
{
    
    private bool ActivelyLooting = false;
    private PlayerInventory Player;
    private int ItemRoll;
    private float AddedQuantity = 0;
    public float BonusQuantity = 0;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<PlayerInventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivelyLooting == true)
        {
            ItemRoll = Random.Range(0, 100);
            Debug.Log ("Player Attempted to Loot");
            if (ItemRoll >= 0 && ItemRoll <= 75)
            {
                AddedQuantity = 4 + BonusQuantity;
                Player.AddQuantityToItem(Player.TestItem, AddedQuantity);
            }
            if (ItemRoll >= 76 && ItemRoll <= 100)
            {
                AddedQuantity = 2 + BonusQuantity;
                Player.AddQuantityToItem(Player.TestItemTwo, AddedQuantity);
            }
            ActivelyLooting = false;
        }
        
    }

    public void ActivateLootGathering()
    {
        ActivelyLooting = true;
    }
}
