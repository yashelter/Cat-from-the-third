using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour 
{
    public Item slotItem;
    public GameObject itemObject;
    public Text countText;
    public SimpleSlot simpleSlot;

    public int countItems = 0;
    private Image icon;
    private Button button;
    private ItemInfo inf;
    

    private void Awake()
    {
        
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        countText = icon.transform.GetChild(0).GetComponent<Text>();
        countText.text = "";

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
        if (item.isStackable)
        {
            countItems++;
            countText.fontSize = 24;
            countText.color = Color.white;
            countText.text = countItems.ToString();
        }

        Debug.Log("Item was putten");
    }

    private void ShowInfo()
    {
        if (slotItem != null && simpleSlot != null)
        {
            inf.OpenInfo(slotItem, itemObject, this, simpleSlot);
        } else
        {
            inf.OpenInfo(slotItem, itemObject, this);
        }
    }

    public void ClearSlot()
    {
        slotItem = null;
        itemObject = null;
        countText.text = "";
        icon.enabled = false;
    }
}
