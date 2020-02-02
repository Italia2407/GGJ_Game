using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletedSimonSays : MonoBehaviour
{
    public int Rate;
    private float Counter;
    private Image selfcolour;
    private bool fadeoutStart = false;
    private void Start()
    {

            Counter = 0;
            selfcolour = GetComponent<Image>();
            if (selfcolour == null)
            {
                Debug.LogErrorFormat("Cannot find colour for fadeout");
            }
    }

    private void Update()
    {
        if (MainSimonSaysController.Completed && !fadeoutStart)
        {
            fadeoutStart = true;
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        for (Counter = 0; Counter<=Rate;Counter+=Time.deltaTime)
        {
            selfcolour.color = new Color(selfcolour.color.r, selfcolour.color.g, selfcolour.color.b, Counter / Rate);
            Debug.Log(Counter);
            yield return 0;
        }
        SceneManager.LoadScene("SampleScene_Tilemap");
    }
}
