using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public string firstLevel = "Hub";

    public void BeginGame()
    {
        SceneManager.LoadScene(firstLevel);
    }
}
