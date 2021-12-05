using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearOnClickIfItemInHands : MonoBehaviour
{
    public bool deleteItem = false;
    GameObject slot;
    GameObject Hand;
    SpriteRenderer item;
    public Sprite requiredItem;
    public SysVal Sys;
    public move2Sprites script;
    void Start()
    {
        Hand = GameObject.Find("Hand");
        item = transform.parent.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (Hand.GetComponent<handStatus>().itemInHands && Hand.transform.GetComponent<SpriteRenderer>().sprite == requiredItem)
        {
            slot = GameObject.Find(Hand.GetComponent<handStatus>().slotName);
            slot.GetComponent<slotStatus>().OnMouseDown();
            item.color = new Color(1, 1, 1, 0);
            script.MoveTheSprite();
            if (deleteItem)
            {
                slot.transform.parent.GetComponent<SpriteRenderer>().sprite = slot.GetComponent<slotStatus>().emptyslot;
                slot.GetComponent<slotStatus>().isEmpty = true;
                slot.GetComponent<slotStatus>().itemID = "";
            }
        }
    }
}
