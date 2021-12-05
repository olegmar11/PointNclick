using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorStatus : MonoBehaviour
{
    public Sprite newSprite;
    GameObject slot;
    GameObject Hand;
    public Sprite requiredItem;
    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }
    private void OnMouseDown()
    {
        if (Hand.transform.GetComponent<SpriteRenderer>().sprite == requiredItem)
        {
            slot = GameObject.Find(Hand.GetComponent<handStatus>().slotName);
            slot.GetComponent<slotStatus>().OnMouseDown();
            slot.transform.parent.GetComponent<SpriteRenderer>().sprite = slot.GetComponent<slotStatus>().emptyslot;
            slot.GetComponent<slotStatus>().isEmpty = true;
            slot.GetComponent<slotStatus>().itemID = "";
            Hand.GetComponent<handStatus>().itemInHands = false;
            Hand.GetComponent<handStatus>().slotName = "";
            Hand.GetComponent<handStatus>().itemName = "";
            transform.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
}
