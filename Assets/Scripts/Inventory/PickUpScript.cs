using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public Item item;
    private GameObject itemObj;

    private InventoryManager inventoryManager;

    private void Awake()
    {
        inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();

        itemObj = gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "CAT") // bad practive, it will be changed (comparing by tag)
        {

            gameObject.SetActive(false);
            inventoryManager.PutIntoEmpty(item, itemObj);
            
            
            Debug.Log("Put Item");
        }
    }
}
