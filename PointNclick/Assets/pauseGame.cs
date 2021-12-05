using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;

    void changeTheScene()
    {
        Vector3 Cam = Camera.main.transform.position;
        GameObject.Find("ContinueButton").GetComponent<continueGame>().x = Cam.x;
        GameObject.Find("ContinueButton").GetComponent<continueGame>().y = Cam.y;
        Cam.x = x;
        Cam.y = y;
        Camera.main.transform.position = Cam;
    }

    private void OnMouseDown()
    {
        changeTheScene();
    }
}
