using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{

    private PlayerInventory Inventory;
    private LootItem ItemLooter;
    public float Material1Req;
    public float Material2Req;
    public float Price;
    private bool PerformUpgrade;
    private bool PerfromCraft;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("Canvas").GetComponent<PlayerInventory>();
        ItemLooter = GameObject.Find("Canvas").GetComponent<LootItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeCheck()
    {
        if (Inventory.PlayerCurrency >= Price)
        {
            Inventory.RemoveGold(Price);
            PerformUpgrade = true;
            Price = Price * 2f;
        }
    }

    public void CraftCheck()
    {
        if (Inventory.TestItem.ItemAmount >= Material1Req && Inventory.TestItemTwo.ItemAmount >= Material2Req)
        {
            Inventory.RemoveItem(Inventory.TestItem, Material1Req);
            Inventory.RemoveItem(Inventory.TestItemTwo, Material2Req);
            PerfromCraft = true;
        }
    }

    public void IncreaseQuantUpgrade()
    {
        if (PerformUpgrade == true)
        {
            ItemLooter.BonusQuantity = ItemLooter.BonusQuantity + 1;
            PerformUpgrade = false;
        }
    }

    public void CraftWoodWeapon()
    {
        if (PerfromCraft == true)
        {
            Inventory.Sword.ItemAmount = Inventory.Sword.ItemAmount + 1;
            PerfromCraft = false;
        }
    }

    public void CraftPickaxe()
    {
        if (PerfromCraft == true)
        {
            Inventory.Pick.ItemAmount = Inventory.Pick.ItemAmount + 1;
            PerfromCraft = false;
        }
    }
}
