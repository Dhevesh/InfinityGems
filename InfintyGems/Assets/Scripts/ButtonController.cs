using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    private Button[] buttons;
    private Button playButton;
    private Button stopButton;

    void Awake()
    {
        buttons = FindObjectsOfType<Button>();
        foreach(Button b in buttons)
        {
            if (b.name == "PlayButton")
                playButton = b;
            else if (b.name == "StopButton")
                stopButton = b;
        }
    }

    void Start()
    {
        stopButton.gameObject.SetActive(false);
    }
    public void PlayButtonClicked()
    {
        FindObjectOfType<GameManager>().Spin();
        playButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
    }

    public void StopButtonClicked()
    {
        FindObjectOfType<GameManager>().Stop();
        stopButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);

    }

}
