using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTime : MonoBehaviour
{
    System.DateTime time;
    public GameObject item;

    void Update()
    {
        time = System.DateTime.Now;
        if (time.Hour == 20)
        {
            // Stuff //
        }
    }
}
