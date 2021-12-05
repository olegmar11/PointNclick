using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuseBoxLever : MonoBehaviour
{
    public Sprite box2, boxOn;
    private void OnMouseDown()
    {
        if(transform.parent.GetComponent<SpriteRenderer>().sprite == box2)
        {
            transform.parent.GetComponent<SpriteRenderer>().sprite = boxOn;
            GameObject.Find("SystemValues").GetComponent<SysVal>().electricityOn = true;
        }
    }
}
