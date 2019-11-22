using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetInventoryUI : MonoBehaviour
{
    private Item currentItem;
    public TMP_Text ItemName;
    public TMP_Text Quality;
    public TMP_Text ItemValue;
    public TMP_Text ItemQuantity;
    public Image ItemImage;

    // Start is called before the first frame update
    void Start()
    {
        currentItem = GetComponent<Item>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ItemName.text = currentItem.ItemName;
        ItemQuantity.text = "x" + currentItem.ItemAmount.ToString();
        ItemImage.sprite = currentItem.ItemImage;
        if (currentItem.IsHighQuality == true)
        {
            Quality.text = "(HQ)";
            ItemValue.text = currentItem.HQValue.ToString();
        }
        else
        {
            Quality.text = "(NQ)";
            ItemValue.text = currentItem.Value.ToString();
        }
    }
}
