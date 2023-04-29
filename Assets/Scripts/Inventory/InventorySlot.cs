using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventorySlot : MonoBehaviour 
{
    public Item slotItem;
    public GameObject itemObject;

    private Image icon;
    private Button button;
    private ItemInfo inf;
    

    private void Awake()
    {
        
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        icon.enabled = false;
        button = GetComponent<Button>();
        inf = GameObject.Find("Info").GetComponent<ItemInfo>();
    }

    private void Start()
    {
        button.onClick.AddListener(ShowInfo);
    }

    public void PutItem(Item item, GameObject obj)
    {
        icon.sprite = item.icon;
        slotItem = item;
        icon.enabled = true;    
        itemObject = obj; 
        Debug.Log("Item was putten");
    }

    private void ShowInfo()
    {
        if (slotItem != null)
        {
            inf.OpenInfo(slotItem, itemObject, this);
        }
    }

    public void ClearSlot()
    {
        slotItem = null;
        itemObject = null;
        icon.enabled = false;
    }
}
