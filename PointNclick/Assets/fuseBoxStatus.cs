using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuseBoxStatus : MonoBehaviour
{
    GameObject slot;
    public Sprite boxStart, box1, box2;
    GameObject Hand;

    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }

    private void OnMouseDown()
    {
        if (transform.parent.GetComponent<SpriteRenderer>().sprite == box1 && Hand.GetComponent<handStatus>().itemName == "fuse")
        {
            transform.parent.GetComponent<SpriteRenderer>().sprite = box2;
            deleteFuse();
        }
        if (transform.parent.GetComponent<SpriteRenderer>().sprite == boxStart && Hand.GetComponent<handStatus>().itemName == "fuse")
        {
            transform.parent.GetComponent<SpriteRenderer>().sprite = box1;
            deleteFuse();
        }
    }
    void deleteFuse()
    {
        slot = GameObject.Find(Hand.GetComponent<handStatus>().slotName);
        slot.GetComponent<slotStatus>().OnMouseDown();
        slot.transform.parent.GetComponent<SpriteRenderer>().sprite = slot.GetComponent<slotStatus>().emptyslot;
        slot.GetComponent<slotStatus>().isEmpty = true;
        slot.GetComponent<slotStatus>().itemID = "";
        Hand.GetComponent<handStatus>().itemInHands = false;
        Hand.GetComponent<handStatus>().slotName = "";
        Hand.GetComponent<handStatus>().itemName = "";
        GameObject.Find("SystemValues").GetComponent<SysVal>().electricityOn = true;
    }
}
