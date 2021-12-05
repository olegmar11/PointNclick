using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    public float alpha = 0f;
    public bool isLoading = false;
    GameObject blackscreen;
    void Start()
    {
        blackscreen = transform.gameObject;
        blackscreen.transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    public void loadingTime()
    {
        alpha = 0f;
        isLoading = true;
    }
    public void unLoadingTime()
    {
        alpha = 1f;
        isLoading = false;
    }
    void Update()
    {
        if (isLoading && alpha < 1)
        {
            blackscreen.transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            alpha += 0.01f;
        }
        if (!isLoading && alpha > 0)
        {
            blackscreen.transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            alpha -= 0.01f;
        }
    }
}
