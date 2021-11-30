using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2Sprites : MonoBehaviour
{
    public bool resetInventoryPos = false;
    public bool onClick = false;
    public float x = 0f;
    public float y = 0f;
    public GameObject sprite;
    public float x2 = 0f;
    public float y2 = 0f;
    public GameObject sprite2;

    private void OnMouseDown()
    {
        if (onClick)
        {
            MoveTheSprite();
        }
        if (resetInventoryPos)
        {
            transform.GetComponent<inventoryMenuReset>().resetInventory();
        }
    }

    public void MoveTheSprite()
    {
        Vector3 Pos = sprite.transform.position;
        Pos.x = x;
        Pos.y = y;
        sprite.transform.position = Pos;
        Pos.x = x2;
        Pos.y = y2;
        sprite2.transform.position = Pos;
    }
}
