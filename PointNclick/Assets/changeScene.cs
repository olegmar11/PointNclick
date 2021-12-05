using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public GameObject start;
    public GameObject finish;
    public bool needTorch = false;
    public float x = 0f;
    public float y = 0f;

    void changeTheScene()
    {
        start.GetComponent<loading>().loadingTime();
        Vector3 Cam = Camera.main.transform.position;
        Cam.x = x;
        Cam.y = y;
        Camera.main.transform.position = Cam;
        Cam.x = x + 10f;
        Cam.z = 0f;
        GameObject.Find("Inventory").transform.position = Cam;
        GameObject.Find("InvBox").GetComponent<inventoryMenuReset>().resetInventory();
        finish.GetComponent<loading>().unLoadingTime();
    }

    private void OnMouseDown()
    {
        if(needTorch && GameObject.Find("SystemValues").GetComponent<SysVal>().hasTorch)
        {
            changeTheScene();
        }
        if (!needTorch)
        {
            changeTheScene();
        }
    }
}
