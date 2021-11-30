using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysVal : MonoBehaviour
{
    public slotStatus slot1, slot2, slot3, slot4, slot5;
    public Sprite torch, fuse, key;
    public Sprite torchslot, fuseslot, keyslot;

    public Sprite getSprite(string ID)
    {
        switch(ID){
            case "torch":
                return torch;
            case "fuse":
                return fuse;
            case "key":
                return key;
            case "torchslot":
                return torchslot;
            case "fuseslot":
                return fuseslot;
            case "keyslot":
                return keyslot;
        }
        return torch;
    }
}
