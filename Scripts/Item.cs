using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ItemName;
    public float Value;
    public float HQValue;
    public bool IsHighQuality;
    public float ItemAmount = 0;
    public float ItemMaxAmount = 99;
    public Sprite ItemImage;
}
