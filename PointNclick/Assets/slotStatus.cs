using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotStatus : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public bool isEmpty = true;
    public string itemID;
    public Sprite emptyslot;
    public bool inHands = false;
    GameObject Hand;
    public SpriteRenderer slot;
    public SysVal Sys;
    public float cardCounter = 0f;

    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }
    public void OnMouseDown()
    {
        if (inHands)
        {
            Hand.transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            inHands = false;
            Hand.GetComponent<handStatus>().itemInHands = false;
            Hand.GetComponent<handStatus>().slotName = "";
            Hand.GetComponent<handStatus>().itemName = "";
            slot.sprite = Sys.getSprite(itemID + "slot");
            return;
        }
        if(itemID != "")
        {
            Hand.transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            Hand.transform.GetComponent<SpriteRenderer>().sprite = Sys.getSprite(itemID);
            Hand.GetComponent<handStatus>().itemInHands = true;
            Hand.GetComponent<handStatus>().slotName = transform.name;
            Hand.GetComponent<handStatus>().itemName = itemID;
            inHands = true;
            slot.sprite = emptyslot;
        }
    }
    void Update()
    {
        slot = transform.parent.GetComponent<SpriteRenderer>();
        if (inHands)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = -2;
            Hand.transform.position = mousePosition;
        }
        if (slot.sprite == Sys.getSprite("redcardslot") || slot.sprite == Sys.getSprite("bluecardslot"))
        {
            if (!inHands)
            {
                cardCounter += Time.deltaTime;
                if (cardCounter >= 60)
                {
                    cardCounter = 0f;
                    slot.sprite = Sys.getSprite("yellowcardslot");
                    itemID = "yellowcard";
                }
            }
        }
    }
}
