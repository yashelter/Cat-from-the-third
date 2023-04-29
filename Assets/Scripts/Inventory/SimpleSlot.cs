using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleSlot : MonoBehaviour // same with InventorySlot but for SimpleSlot
{
    public Item simpleItem;

    private Image icon;
    private Button button;



    private void Awake()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        icon.enabled = false;
        button = GetComponent<Button>();
    }

    public void PutSimpleItem(Item item) 
    {
        icon.sprite = item.icon;
        simpleItem = item;
        icon.enabled = true;
        Debug.Log("Simple item was putten");
    }
}
