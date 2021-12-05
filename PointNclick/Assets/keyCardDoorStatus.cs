using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCardDoorStatus : MonoBehaviour
{
    public Sprite openeddoor;
    public float x = 0f;
    public float y = 0f;
    private void OnMouseDown()
    {
        if(transform.parent.GetComponent<SpriteRenderer>().sprite == openeddoor)
        {
            Vector3 Cam = Camera.main.transform.position;
            Cam.x = x;
            Cam.y = y;
            Camera.main.transform.position = Cam;
        }
    }
}
