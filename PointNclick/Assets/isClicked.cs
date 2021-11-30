using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isClicked : MonoBehaviour
{
    GameObject slot1, slot2, slot3, slot4, slot5;
    public string ID;
    public Sprite slotSprite;
    SpriteRenderer item;
    public bool inInventory = false;

    int inventorySlotCheck()
    {
        if (slot1.GetComponent<slotStatus>().isEmpty == true)
        {
            slot1.transform.parent.GetComponent<SpriteRenderer>().sprite = slotSprite;
            slot1.GetComponent<slotStatus>().isEmpty = false;
            slot1.GetComponent<slotStatus>().itemID = ID;
            return 0;
        }
        if (slot2.GetComponent<slotStatus>().isEmpty == true)
        {
            slot2.transform.parent.GetComponent<SpriteRenderer>().sprite = slotSprite;
            slot2.GetComponent<slotStatus>().isEmpty = false;
            slot2.GetComponent<slotStatus>().itemID = ID;
            return 0;
        }
        if (slot3.GetComponent<slotStatus>().isEmpty == true)
        {
            slot3.transform.parent.GetComponent<SpriteRenderer>().sprite = slotSprite;
            slot3.GetComponent<slotStatus>().isEmpty = false;
            slot3.GetComponent<slotStatus>().itemID = ID;
            return 0;
        }
        if (slot4.GetComponent<slotStatus>().isEmpty == true)
        {
            slot4.transform.parent.GetComponent<SpriteRenderer>().sprite = slotSprite;
            slot4.GetComponent<slotStatus>().isEmpty = false;
            slot4.GetComponent<slotStatus>().itemID = ID;
            return 0;
        }
        if (slot5.GetComponent<slotStatus>().isEmpty == true)
        {
            slot5.transform.parent.GetComponent<SpriteRenderer>().sprite = slotSprite;
            slot5.GetComponent<slotStatus>().isEmpty = false;
            slot5.GetComponent<slotStatus>().itemID = ID;
            return 0;
        }
        return 0;
    }
        
    private void Start()
    {
        item = transform.parent.GetComponent<SpriteRenderer>();
        slot1 = GameObject.Find("slot1Box");
        slot2 = GameObject.Find("slot2Box");
        slot3 = GameObject.Find("slot3Box");
        slot4 = GameObject.Find("slot4Box");
        slot5 = GameObject.Find("slot5Box");
    }
    private void OnMouseDown()
    {
        inInventory = true;
        item.color = new Color(1, 1, 1, 0);
        
        inventorySlotCheck();
        transform.GetComponent<moveSprite>().MoveTheSprite();
    }
}
