using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycardReaderStatus : MonoBehaviour
{
    GameObject slot;
    public Sprite reader0, reader1, reader2, reader3;
    GameObject Hand;

    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }

    private void OnMouseDown()
    {
        if (transform.GetComponent<SpriteRenderer>().sprite == reader2 && Hand.GetComponent<handStatus>().itemName == "redcard")
        {
            transform.GetComponent<SpriteRenderer>().sprite = reader3;
            GameObject.Find("SoundManager").GetComponent<soundPlayer>().PlayGood();
            GameObject.Find("KeyCardDoor").GetComponent<SpriteRenderer>().sprite = GameObject.Find("KeyCardDoorBox").GetComponent<keyCardDoorStatus>().openeddoor;
            GameObject.Find("keycard_door_closed_ent").GetComponent<SpriteRenderer>().sprite = GameObject.Find("KeyCardDoorBox").GetComponent<keyCardDoorStatus>().openeddoor;
            return;
        }
        if (transform.GetComponent<SpriteRenderer>().sprite == reader1 && Hand.GetComponent<handStatus>().itemName == "bluecard")
        {
            transform.GetComponent<SpriteRenderer>().sprite = reader2;
            GameObject.Find("SoundManager").GetComponent<soundPlayer>().PlayGood();
            return;
        }
        if (transform.GetComponent<SpriteRenderer>().sprite == reader0 && Hand.GetComponent<handStatus>().itemName == "yellowcard")
        {
            transform.GetComponent<SpriteRenderer>().sprite = reader1;
            GameObject.Find("SoundManager").GetComponent<soundPlayer>().PlayGood();
            return;
        }
        if (transform.GetComponent<SpriteRenderer>().sprite == reader1 && Hand.GetComponent<handStatus>().itemName != "bluecard" || transform.parent.GetComponent<SpriteRenderer>().sprite == reader2 && Hand.GetComponent<handStatus>().itemName != "redcard")
        {
            transform.GetComponent<SpriteRenderer>().sprite = reader0;
            GameObject.Find("SoundManager").GetComponent<soundPlayer>().PlayBad();
        }
    }
}
