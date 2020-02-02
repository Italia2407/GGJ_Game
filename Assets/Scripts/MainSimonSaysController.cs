using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSimonSaysController : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;

    public static MainSimonSaysController instance;
    public static bool number_to_be_generated;
    public static int number_of_flashes;
    public static int[] input = new int[6];
    public static int[] output = new int[6];
    public static int selected;
    public static bool user_input, FadeOutComplete;
    private static int user_index;
    public static int Current_Flash;
    public static bool Completed;
    private static bool StartFlashes;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        selected = 0;
        user_input = false;
        number_of_flashes = 1;
        Current_Flash = 1;
        StartFlashes = true;
        user_index = 0;
        FadeOutComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (StartFlashes)
        {
            StartFlashes = false;
            StartCoroutine(Show_Numbers());
            Debug.Log("Show Coroutine");
        }
        if (user_input)
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {

                selected += 1;
                selected %= 3;
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                selected += 2;
                selected %= 3;
            }
            else if (Input.GetButtonDown("Jump"))
            {
                if (selected == output[user_index])
                {
                    user_index += 1;
                    if (user_index == number_of_flashes)
                    {
                        
                        number_of_flashes += 1;
                        if (number_of_flashes > 6)
                        {

                            Completed = true;
                            user_input = false;


                            audio.Play();
                            FoundPiecesData.SimonSaysFound();
                            SceneManager.LoadScene("Hub");
                        }
                        else
                        {
                            output[number_of_flashes - 1] = Random.Range(0, 3);
                            StartFlashes = true;
                            user_index = 0;
                            user_input = false;
                        }

                    }
                }
                else
                {
                    user_index = 0;
                    user_input = false;
                    StartFlashes = true;
                }
            }
        }

    }

    IEnumerator Show_Numbers()
    {
        for (int index = 0; index < number_of_flashes;index++)
        {
            Current_Flash = output[index];
            yield return new WaitForSeconds(1.0f);
            Current_Flash = -1;
            yield return new WaitForSeconds(0.2f);
        }
        Debug.Log("Coroutine Ended");
        Current_Flash = -1;
        user_input = true;
    }


}

