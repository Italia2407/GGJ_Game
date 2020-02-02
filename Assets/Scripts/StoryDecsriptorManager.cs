using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryDecsriptorManager : MonoBehaviour
{
    [SerializeField]
    private Dialogue text;

    public Text sentenceText;
    public string levelToLoad = "TestScene";

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
        foreach (string sentence in text.lines)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            SceneManager.LoadScene(levelToLoad);
            return;
        }

        sentenceText.text = sentences.Dequeue();
    }
}
