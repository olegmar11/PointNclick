using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearOnClick : MonoBehaviour
{
    public isClicked itemClicked;
    SpriteRenderer item;
    public moveSprite script;
    void Start()
    {
        item = transform.parent.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (itemClicked.inInventory)
        {
            item.color = new Color(1, 1, 1, 0);
            script.MoveTheSprite();
        }
    }
}
