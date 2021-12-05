using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryMenuReset : MonoBehaviour
{
    GameObject inventory;

    public void resetInventory()
    {
        inventory = GameObject.Find("InvBox");
        inventory.GetComponent<menuAppear>().mouseOver = false;
        inventory.GetComponent<menuAppear>().offsetX = 0f;
    }
}
