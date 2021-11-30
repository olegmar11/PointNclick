using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    SpriteRenderer arrow;

    private void Start()
    {
        arrow = transform.parent.GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Vector3 Cam = Camera.main.transform.position; 
        Cam.x = x;
        Cam.y = y;
        Camera.main.transform.position = Cam;
    }
}
