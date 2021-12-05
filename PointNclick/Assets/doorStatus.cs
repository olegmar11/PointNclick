using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorStatus : MonoBehaviour
{
    public Sprite newSprite;
    GameObject slot;
    GameObject Hand;
    public Sprite requiredItem;
    public GameObject start;
    public GameObject finish;
    public float x = 0f;
    public float y = 0f;

    void changeTheScene()
    {
        start.GetComponent<loading>().loadingTime();
        Vector3 Cam = Camera.main.transform.position;
        Cam.x = x;
        Cam.y = y;
        Camera.main.transform.position = Cam;
        Cam.x = x + 10f;
        Cam.z = 0f;
        GameObject.Find("Inventory").transform.position = Cam;
        GameObject.Find("InvBox").GetComponent<inventoryMenuReset>().resetInventory();
        finish.GetComponent<loading>().unLoadingTime();
    }
    private void Start()
    {
        Hand = GameObject.Find("Hand");
    }
    private void OnMouseDown()
    {
        if (transform.GetComponent<SpriteRenderer>().sprite == newSprite)
        {
            changeTheScene();
        }
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
