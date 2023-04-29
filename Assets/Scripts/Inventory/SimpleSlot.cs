using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleSlot : MonoBehaviour // same with InventorySlot but for SimpleSlot
{
    public Item simpleItem;
    public GameObject itemObject;

    private Image icon;
    private Button button;
    private Text countText;


    private void Awake()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        countText = icon.transform.GetChild(0).GetComponent<Text>();
        icon.enabled = false;
        button = GetComponent<Button>();
    }

    public void PutSimpleItem(Item item, GameObject simpleObj) 
    {
        icon.sprite = item.icon;
        itemObject = simpleObj;
        simpleItem = item;
        icon.enabled = true;
        if (item.isStackable)
        {
            countText.fontSize = 24;
            countText.text = "1";
        }
        Debug.Log("Simple item was putten");
    }

    public void ClearSimpleSlot()
    {
        simpleItem = null;
        itemObject = null;
        icon.enabled = false;
        countText.text = "";
    }
}
