using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Button openButton;
    public Image inventoryBackground;
    public Image simpleInventory;

    public Transform slotsParent;
    public Transform simpleParent; // for simpleSlots

    private InventorySlot[] inventorySlots = new InventorySlot[20];
    private SimpleSlot[] simpleSlots = new SimpleSlot[5];
    private bool isOpen = false;


    private void Awake()
    {
        for (int i = 0; i < inventorySlots.Length; ++i)
        {
            inventorySlots[i] = slotsParent.GetChild(i).GetComponent<InventorySlot>();
        }

        for (int i = 0; i < simpleSlots.Length; ++i)
        {
            simpleSlots[i] = simpleParent.GetChild(i).GetComponent<SimpleSlot>();
        }

    }

    private void Start()
    {
        simpleInventory.transform.localScale = Vector3.one;
        inventoryBackground.transform.localScale = Vector3.zero;
    }

    public void PutIntoEmpty(Item item, GameObject obj) // find nearly empty slot
    {
        for (int i = 0; i < inventorySlots.Length; ++i)
        {
            if (inventorySlots[i].slotItem == null)
            {
                inventorySlots[i].PutItem(item, obj);
                Debug.Log("Slot " + i + " isnt empty");

                if (i <= 4 && simpleSlots[i].simpleItem == null)
                {
                    simpleSlots[i].PutSimpleItem(item);
                    Debug.Log("SimpleSlot " + i + " isnt empty");
                    return;
                }

                return;
            }
            
        }
    }



    public void Open() // turn on inventory and turn off inventoryOpen button
    {
        if (!isOpen)
        {
            simpleInventory.transform.localScale = Vector3.zero;
            openButton.transform.localScale = Vector3.zero;
            inventoryBackground.transform.localScale = Vector3.one;
            isOpen = true;
        }
    }

    public void Close() // turn off inventory
    {
        if (isOpen)
        {
            simpleInventory.transform.localScale = Vector3.one; // open simple inventory(only 5 slots)
            openButton.transform.localScale = Vector3.one;
            inventoryBackground.transform.localScale = Vector3.zero;
            isOpen = false;
        }
    }
        
        
}
