using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    private Button[] buttons;
    [HideInInspector]
    public Button playButton;
    [HideInInspector]
    public Button stopButton;

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
        FindObjectOfType<SymbolController>().Spin();
        playButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
    }

    public void StopButtonClicked()
    {
        FindObjectOfType<SymbolController>().Stop();
        stopButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
    }

    public void DenominationButtonClicked()
    {
        FindObjectOfType<CoinDenomController>().ChangeDenomination();
    }

}
