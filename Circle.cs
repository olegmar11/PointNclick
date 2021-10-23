using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Texture2D cursordef;
    public Texture2D cursorhover;

    void Start()
    {
        Cursor.SetCursor(cursordef, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorhover, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursordef, Vector2.zero, CursorMode.ForceSoftware);
    }
    private Vector2 target = new Vector2(0,0);
    private void OnMouseDown()
    {
       
    }

}
