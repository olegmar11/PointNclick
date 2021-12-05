using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fridgeStatus : MonoBehaviour
{
    public Sprite fridgeclosed, fridgeopen, fridgeopenred, fridgeopenblue, fridgeopenyellow;
    public float counter = 0f;
    GameObject Hand, slot;
    public bool hasKeycard = false;
    public string keyColor = "";
    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }
    private void OnMouseDown()
    {
        if (GameObject.Find("SystemValues").GetComponent<SysVal>().electricityOn)
        {
            if (transform.GetComponent<SpriteRenderer>().sprite == fridgeopen || transform.GetComponent<SpriteRenderer>().sprite == fridgeopenred || transform.GetComponent<SpriteRenderer>().sprite == fridgeopenblue || transform.GetComponent<SpriteRenderer>().sprite == fridgeopenyellow)
            {
                if (Hand.GetComponent<handStatus>().itemInHands == false)
                {
                    transform.GetComponent<SpriteRenderer>().sprite = fridgeclosed;
                    return;
                }
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == fridgeclosed && Hand.GetComponent<handStatus>().itemInHands == false)
            {
                transform.GetComponent<SpriteRenderer>().sprite = fridgeopen;
                if(keyColor == "redcard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = fridgeopenred;
                }
                if (keyColor == "bluecard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = fridgeopenblue;
                }
                if (keyColor == "yellowcard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = fridgeopenyellow;
                }
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == fridgeopen && Hand.GetComponent<handStatus>().itemName == "yellowcard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = fridgeopenyellow;
                RemoveItem();
                keyColor = "yellowcard";
                hasKeycard = true;
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == fridgeopen && Hand.GetComponent<handStatus>().itemName == "redcard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = fridgeopenred;
                keyColor = "redcard";
                RemoveItem();
                hasKeycard = true;
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == fridgeopen && Hand.GetComponent<handStatus>().itemName == "bluecard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = fridgeopenblue;
                keyColor = "bluecard";
                RemoveItem();
                hasKeycard = true;
            }
            counter = 0f;
        }
    }
    void RemoveItem()
    {
        slot = GameObject.Find(Hand.GetComponent<handStatus>().slotName);
        slot.GetComponent<slotStatus>().OnMouseDown();
        slot.transform.parent.GetComponent<SpriteRenderer>().sprite = slot.GetComponent<slotStatus>().emptyslot;
        slot.GetComponent<slotStatus>().isEmpty = true;
        slot.GetComponent<slotStatus>().itemID = "";
        Hand.GetComponent<handStatus>().itemInHands = false;
        Hand.GetComponent<handStatus>().slotName = "";
        Hand.GetComponent<handStatus>().itemName = "";
    }
    private void Update()
    {
        if (hasKeycard && transform.GetComponent<SpriteRenderer>().sprite == fridgeclosed)
        {
            counter += Time.deltaTime;
            if(counter >= 10f)
            {
                counter = 0f;
                keyColor = "bluecard";
            }
        }
    }
}
