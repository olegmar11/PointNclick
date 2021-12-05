using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysVal : MonoBehaviour
{
    public bool hasTorch = false, electricityOn = false;
    float alpha = 1f;
    public slotStatus slot1, slot2, slot3, slot4, slot5;
    public Sprite torch, fuse, crowbar, yellowcard, bluecard, redcard;
    public Sprite torchslot, fuseslot, crowbarslot, yellowcardslot, bluecardslot, redcardslot;

    public Sprite getSprite(string ID)
    {
        switch(ID){
            case "torch":
                return torch;
            case "fuse":
                return fuse;
            case "crowbar":
                return crowbar;
            case "yellowcard":
                return yellowcard;
            case "bluecard":
                return bluecard;
            case "redcard":
                return redcard;
            case "torchslot":
                return torchslot;
            case "fuseslot":
                return fuseslot;
            case "crowbarslot":
                return crowbarslot;
            case "yellowcardslot":
                return yellowcardslot;
            case "bluecardslot":
                return bluecardslot;
            case "redcardslot":
                return redcardslot;
        }
        return torch;
    }
    private void Start()
    {
        GameObject.Find("vinette2").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }
    private void Update()
    {
        if (hasTorch && alpha > 0)
        {
            GameObject.Find("vinette1").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            GameObject.Find("vinette2").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            alpha -= 0.01f;
        }
        if (electricityOn)
        {
            GameObject.Find("vinette2").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            GameObject.Find("vinette2Kitchen").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            GameObject.Find("vinette2Ent").transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }
}
