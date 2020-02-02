using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysLights : MonoBehaviour
{
    public Color LightUpColour, DarkColour;
    private SpriteRenderer selfrenderer;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        selfrenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainSimonSaysController.Current_Flash == index)
        {
            selfrenderer.color = LightUpColour;
        }
        else
        {
            selfrenderer.color = DarkColour; 
        }
    }
}
