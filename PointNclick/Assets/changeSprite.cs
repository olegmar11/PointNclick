using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour
{
    public bool moveSprite = false;
    public bool onClick = false;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    private void OnMouseDown()
    {
        if (onClick)
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
        if (moveSprite)
        {
            transform.GetComponent<moveSprite>().MoveTheSprite();
        }
    }
}
