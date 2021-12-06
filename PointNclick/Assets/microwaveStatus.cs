using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwaveStatus : MonoBehaviour
{
    public Sprite microclosed, microopen, microopenred, microopenblue, microopenyellow, microworking;
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
            if (transform.GetComponent<SpriteRenderer>().sprite == microopen || transform.GetComponent<SpriteRenderer>().sprite == microopenred || transform.GetComponent<SpriteRenderer>().sprite == microopenblue || transform.GetComponent<SpriteRenderer>().sprite == microopenyellow)
            {
                if (Hand.GetComponent<handStatus>().itemInHands == false)
                {
                    transform.GetComponent<SpriteRenderer>().sprite = microclosed;
                    return;
                }
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == microclosed && Hand.GetComponent<handStatus>().itemInHands == false)
            {
                transform.GetComponent<SpriteRenderer>().sprite = microopen;
                if (keyColor == "redcard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = microopenred;
                }
                if (keyColor == "bluecard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = microopenblue;
                }
                if (keyColor == "yellowcard")
                {
                    transform.GetComponent<SpriteRenderer>().sprite = microopenyellow;
                }
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == microopen && Hand.GetComponent<handStatus>().itemName == "yellowcard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = microopenyellow;
                RemoveItem();
                keyColor = "yellowcard";
                hasKeycard = true;
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == microopen && Hand.GetComponent<handStatus>().itemName == "redcard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = microopenred;
                keyColor = "redcard";
                RemoveItem();
                hasKeycard = true;
            }
            if (transform.GetComponent<SpriteRenderer>().sprite == microopen && Hand.GetComponent<handStatus>().itemName == "bluecard")
            {
                transform.GetComponent<SpriteRenderer>().sprite = microopenblue;
                keyColor = "bluecard";
                RemoveItem();
                hasKeycard = true;
            }
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
    soundPlayer a;
    private void Update()
    {
        if (hasKeycard && transform.GetComponent<SpriteRenderer>().sprite == microworking)
        {
            counter += Time.deltaTime;
            if (counter >= 10f)
            {
                counter = 0f;
                transform.GetComponent<SpriteRenderer>().sprite = microclosed;
                keyColor = "redcard";
                a.Play_Microwave_end();
            }
        }
    }
}
