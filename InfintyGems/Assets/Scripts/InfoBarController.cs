using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBarController : MonoBehaviour
{
    
    public Text infoBarText;

    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().PlayerCredits == 0)
            infoBarText.text = "INSERT CREDITS";
        else if (FindObjectOfType<GameManager>().PlayerCredits != 0 && infoBarText.text == "INSERT CREDITS")
            infoBarText.text = "";

        if (FindObjectOfType<SymbolController>().IsSpinning)
            infoBarText.text = "GOOD LUCK!";
        else if (!FindObjectOfType<SymbolController>().IsSpinning && FindObjectOfType<GameManager>().PlayerCredits != 0 && infoBarText.text == "GOOD LUCK!")
        {
            infoBarText.text = "";
        }
    }
}
