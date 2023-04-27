using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item slotItem;

    private Image icon;
    private Button button;

    

    private void Awake()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        icon.enabled = false;
        button = GetComponent<Button>();
    }

    public void PutItem(Item item)
    {
        icon.sprite = item.icon;
        slotItem = item;
        icon.enabled = true;    
        Debug.Log("Item was putten");
    }

}
