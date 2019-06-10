using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject coinFountainSpawner;
    [SerializeField]
    private Text playerBalance;


    public int PlayerCredits { get; set; }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<CoinFountainController>().EnableCoinFountain();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            FindObjectOfType<CoinFountainController>().DisableCoinFountain();
        }

        if (playerBalance.text == "0")
        {
            FindObjectOfType<ButtonController>().playButton.interactable = false;
        }
        else
            FindObjectOfType<ButtonController>().playButton.interactable = true;

        if (Convert.ToInt32(FindObjectOfType<BetController>().betText.text) > Convert.ToInt32(playerBalance.text))
            FindObjectOfType<ButtonController>().playButton.interactable = false;
        else
            FindObjectOfType<ButtonController>().playButton.interactable = true;
    }

    public void GamePlay()
    {
        if (playerBalance.text != "0")
        {
            int betAmount = Convert.ToInt32(FindObjectOfType<BetController>().betText.text);
            PlayerCredits -= betAmount;
            playerBalance.text = PlayerCredits.ToString();
        }
    }

    public void ChangeDenom()
    {
        string denomText = FindObjectOfType<CoinDenomController>().coinDenomButtonText.text;
        if (denomText.Contains("$"))
        {
            denomText = denomText.Replace("$", "");
        }
        else if (denomText.Contains("¢"))
        {
            denomText = denomText.Replace("¢", "");
        }
        int denomValue = Convert.ToInt32(denomText);


        if (PlayerCredits != 0)
        {
            playerBalance.text = Convert.ToString(PlayerCredits / denomValue);
        }

    }
}
