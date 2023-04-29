using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemInfo : MonoBehaviour
{
    public static ItemInfo instance;

    private Item infoItem;
    private Image backGround;
    private TMP_Text title;
    private TMP_Text description;
    private TMP_Text properties;

    private Button exitButton;
    private Button dropButton;
    private Button useButton;

    private GameObject itemObject; 
    

    private UseOfItems useOfItems;
    private Player player;

    private InventorySlot currSlot;
    private SimpleSlot currSimpleSlot;

    private void Awake()
    {
        useOfItems = GameObject.Find("UseOfItems").GetComponent<UseOfItems>();
        player = GameObject.Find("CAT").GetComponent<Player>();

        backGround = GetComponent<Image>();
        title = transform.GetChild(0).GetComponent<TMP_Text>();
        description = transform.GetChild(1).GetComponent<TMP_Text>();
        properties = transform.GetChild(2).GetComponent<TMP_Text>();
        exitButton = transform.GetChild(3).GetComponent<Button>();
        useButton = transform.GetChild(4).GetComponent<Button>();
        dropButton = transform.GetChild(5).GetComponent<Button>();

        exitButton.onClick.AddListener(CloseInfo);
        useButton.onClick.AddListener(UseButton);
        dropButton.onClick.AddListener(Drop);
    }

    private void Start()
    {
        instance = this;

        backGround.transform.localScale = Vector3.zero;
    }

    public void ChangeInfo(Item item)
    {
        title.text = item.title.ToString();
        description.text = item.description.ToString();
        properties.text = item.properties.ToString();
    }

    public void UseButton()
    {
        useOfItems.Use(infoItem); // Need to create some use-function in UseOfItems class
    }

    public void Drop()
    {
        Vector3 dropPos;
        if (player.isFliped)
        {
            dropPos = new Vector3(player.transform.position.x + 6f, player.transform.position.y - 1f, player.transform.position.x);
        } else
        {
            dropPos = new Vector3(player.transform.position.x - 6f, player.transform.position.y - 1f, player.transform.position.x);
        }
        
        itemObject.SetActive(true);
        itemObject.transform.position = dropPos;
        
        currSlot.ClearSlot();
        currSimpleSlot.ClearSimpleSlot();
        CloseInfo();
    }

    public void OpenInfo(Item item, GameObject itemObject_, InventorySlot currSlot_, SimpleSlot simpleSlot_ = null)
    {
        ChangeInfo(item);
        infoItem = item;
        itemObject = itemObject_;
        currSlot = currSlot_;
        currSimpleSlot = simpleSlot_;
        backGround.transform.localScale = Vector3.one;
    }

    public void CloseInfo()
    {
        backGround.transform.localScale = Vector3.zero;
    }

}
