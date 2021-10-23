using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isClicked : MonoBehaviour
{
    SpriteRenderer crowbar;

    private void Start()
    {
        crowbar = transform.parent.GetComponent<SpriteRenderer>(); // ќтримуЇмо спрайт в≥д батька
    }
    private void OnMouseDown()
    {
        crowbar.color = new Color(1, 1, 1, 0); // як≥йсь д≥њ
    }
}
