using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoPanelController : MonoBehaviour
{
    public Dropdown creditsAmountDropDown;
    public Text playerCreditsText;
    public GameObject demoPanel;
    private bool isActive;

    void InsertCredits()
    {
        int dropDownIndex = creditsAmountDropDown.value;
        string dropDownToCredits = creditsAmountDropDown.options[dropDownIndex].text;
        dropDownToCredits = dropDownToCredits.Replace("$", "");
        int dropDownToCreditsInt = Convert.ToInt32(dropDownToCredits);
        FindObjectOfType<GameManager>().PlayerCredits += dropDownToCreditsInt;
        playerCreditsText.text = Convert.ToString(FindObjectOfType<GameManager>().PlayerCredits / FindObjectOfType<CoinDenomController>().DenomValue);
    }


    public void InsertCreditsButton_Click()
    {
        InsertCredits();
    }

    public void CashoutButton_Click()
    {
        FindObjectOfType<GameManager>().PlayerCredits = 0;
        playerCreditsText.text = FindObjectOfType<GameManager>().PlayerCredits.ToString();
    }

    public void ToggleDemoPanel()
    {
        if (!isActive)
        {
            demoPanel.SetActive(true);
            isActive = true;
        }
        else
        {
            demoPanel.SetActive(false);
            isActive = false;
        }
    }
}
