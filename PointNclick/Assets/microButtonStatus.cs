using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microButtonStatus : MonoBehaviour
{
    GameObject Hand, Microwave;
    private void Start()
    {
        Hand = GameObject.Find("Hand");
        Microwave = GameObject.Find("Microwave");
    }
    private void OnMouseDown()
    {
        if(Microwave.GetComponent<microwaveStatus>().hasKeycard && Hand.GetComponent<handStatus>().itemInHands == false && GameObject.Find("SystemValues").GetComponent<SysVal>().electricityOn && Microwave.GetComponent<SpriteRenderer>().sprite == Microwave.GetComponent<microwaveStatus>().microclosed)
        {
            Microwave.GetComponent<SpriteRenderer>().sprite = Microwave.GetComponent<microwaveStatus>().microworking;
        }
    }
}
