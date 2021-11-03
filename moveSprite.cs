using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSprite : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public GameObject sprite;


    public void MoveTheSprite()
    {
        Vector3 Pos = sprite.transform.position;
        Pos.x = x;
        Pos.y = y;
        sprite.transform.position = Pos;
    }
}
