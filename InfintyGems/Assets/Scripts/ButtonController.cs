using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    private Button[] buttons;
    [HideInInspector]
    public Button playButton, stopButton,autoPlayButton,coinDenomButton,helpButton,multiGameButton,increaseCreditsButton,decreaseCreditsButton;
   
    void Awake()
    {
        buttons = FindObjectsOfType<Button>();
        foreach(Button b in buttons)
        {
            switch (b.name)
            {
                case "PlayButton":
                    playButton = b;
                    break;
                case "StopButton":
                    stopButton = b;
                    break;
                case "AutoPlayButton":
                    autoPlayButton = b;
                    break;
                case "CoinDenomButton":
                    coinDenomButton = b;
                    break;
                case "HelpButton":
                    helpButton = b;
                    break;
                case "MultiGameButton":
                    multiGameButton = b;
                    break;
                case "IncreaseCreditsButton":
                    increaseCreditsButton = b;
                    break;
                case "DecreaseCreditsButton":
                    decreaseCreditsButton = b;
                    break;
            }
        }
    }

    void Start()
    {
        stopButton.gameObject.SetActive(false);
    }
    public void PlayButtonClicked()
    {
        FindObjectOfType<SymbolController>().Spin();
        FindObjectOfType<GameManager>().GamePlay();
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
        FindObjectOfType<GameManager>().ChangeDenom();
    }

    public void IncreaseBetButtonClicked()
    {
        FindObjectOfType<BetController>().IncreaseBet();
    }

    public void DecreaseBetButtonClicked()
    {
        FindObjectOfType<BetController>().DecreaseBet();
    }

    public void MenuButtonClicked()
    {
        FindObjectOfType<DemoPanelController>().ToggleDemoPanel();
    }

    public void HelpButtonClicked()
    {
        FindObjectOfType<PaytableController>().TogglePaytable();
    }

    public void DisableButtons()
    {
        multiGameButton.interactable = false;
        helpButton.interactable = false;
        coinDenomButton.interactable = false;
        autoPlayButton.interactable = false;
    }

}
