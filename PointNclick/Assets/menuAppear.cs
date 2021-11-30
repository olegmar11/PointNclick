using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAppear : MonoBehaviour
{
    public bool mouseOver = false;
    public GameObject item;
    public GameObject itemBox;
    public GameObject slot1, slot2, slot3, slot4, slot5;
    Vector3 offset = new Vector3(0.02f, 0, 0);
    public float counter = 0f;
    public float offsetX = 0f;

    void OnMouseEnter()
    {
        mouseOver = true;
        counter = 0f;
    }

    void Idle()
    {
        if (mouseOver)
        {
            counter += Time.deltaTime;
            if (counter >= 4)
            {
                mouseOver = false;
                counter = 0f;
            }
        }
    }

    void Update()
    {
        Idle();
        if (mouseOver)
        {
            if (offsetX > -2.3)
            {
                item.transform.position -= offset;
                itemBox.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, 0);
                offsetX -= 0.02f;
            }
        }
        else
        {
            if (offsetX < 0)
            {
                item.transform.position += offset;
                itemBox.transform.position = new Vector3(item.transform.position.x - 0.5f, item.transform.position.y, 0);
                offsetX += 0.02f;
            }
        }
        slot1.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + 3.85f, -1);
        slot1.transform.parent.position = new Vector3(item.transform.position.x, item.transform.position.y + 3.85f, -1);
        slot2.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + 2f, -1);
        slot2.transform.parent.position = new Vector3(item.transform.position.x, item.transform.position.y + 2f, -1);
        slot3.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + 0.15f, -1);
        slot3.transform.parent.position = new Vector3(item.transform.position.x, item.transform.position.y + 0.15f, -1);
        slot4.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + -1.7f, -1);
        slot4.transform.parent.position = new Vector3(item.transform.position.x, item.transform.position.y + -1.7f, -1);
        slot5.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + -3.55f, -1);
        slot5.transform.parent.position = new Vector3(item.transform.position.x, item.transform.position.y + -3.55f, -1);
    }
}
