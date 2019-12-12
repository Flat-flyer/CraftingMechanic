using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetUpgradeUI : MonoBehaviour
{
    private UpgradeScript Upgrader;
    public TMP_Text PriceText;

    // Start is called before the first frame update
    void Start()
    {
        Upgrader = GetComponent<UpgradeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PriceText != null)
        {
            PriceText.text = "$ " + Upgrader.Price.ToString();
        }
    }
}
