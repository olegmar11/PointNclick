using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwaveKeyStatus : MonoBehaviour
{
    GameObject Microwave;
    GameObject slot1, slot2, slot3, slot4, slot5;
    string ID;
    Sprite slotSprite;
    SpriteRenderer item;
    bool inInventory = false;

    private void Start()
    {
        Microwave = GameObject.Find("Microwave");
        item = transform.parent.GetComponent<SpriteRenderer>();
        slot1 = GameObject.Find("slot1Box");
        slot2 = GameObject.Find("slot2Box");
        slot3 = GameObject.Find("slot3Box");
        slot4 = GameObject.Find("slot4Box");
        slot5 = GameObject.Find("slot5Box");
    }
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
    private void OnMouseDown()
    {
        if (Microwave.GetComponent<microwaveStatus>().hasKeycard)
        {
            Microwave.GetComponent<microwaveStatus>().hasKeycard = false;
            ID = Microwave.GetComponent<microwaveStatus>().keyColor;
            Microwave.GetComponent<microwaveStatus>().keyColor = "";
            slotSprite = GameObject.Find("SystemValues").GetComponent<SysVal>().getSprite(ID + "slot");
            Microwave.GetComponent<SpriteRenderer>().sprite = Microwave.GetComponent<microwaveStatus>().microopen;
            inInventory = true;
            inventorySlotCheck();
        }
    }
}
