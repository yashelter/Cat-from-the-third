using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Button openButton;
    public Image inventoryBackground;
    public Transform slotsParent;
    private InventorySlot[] inventorySlots = new InventorySlot[20];
    private bool isOpen = false;
    private void Awake()
    {
        

        //inventorySlots = FindObjectsOfType<InventorySlot>(); // its also find all object but without sorting order
        for (int i = 0; i < inventorySlots.Length; ++i)
        {
            inventorySlots[i] = slotsParent.GetChild(i).GetComponent<InventorySlot>();
        }

    }

    private void Start()
    {
        inventoryBackground.transform.localScale = Vector3.zero;
    }

    public void PutIntoEmpty(Item item) // find nearly emty slot
    {
        for (int i = 0; i < inventorySlots.Length; ++i)
        {
            if (inventorySlots[i].slotItem == null)
            {
                inventorySlots[i].PutItem(item);
                Debug.Log("Slot " + i + " isnt empty");
                return;
            }
        }
    }

    public void Open() // turn on inventory and turn off inventoryOpen button
    {
        if (!isOpen)
        {
            openButton.transform.localScale = Vector3.zero;
            inventoryBackground.transform.localScale = Vector3.one;
            isOpen = true;
        }
    }

    public void Close() // turn off inventory
    {
        if (isOpen)
        {
            openButton.transform.localScale = Vector3.one;
            inventoryBackground.transform.localScale = Vector3.zero;
            isOpen = false;
        }
    }
        
        
}
