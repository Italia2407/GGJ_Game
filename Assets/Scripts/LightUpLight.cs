using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpLight : MonoBehaviour
{

    public int index;
    private SpriteRenderer lightsprite;

    // Update is called once per frame
    private void Start()
    {
        lightsprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (MainSimonSaysController.selected == index)
        {
            lightsprite.color = new Color(0.5f, 0.5f, 0.5f,1.0f);
        }
        else
        {
            lightsprite.color = new Color(0.1f, 0.1f, 0.1f,1.0f);
        }
    }
}
