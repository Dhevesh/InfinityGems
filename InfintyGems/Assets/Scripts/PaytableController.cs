using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaytableController : MonoBehaviour
{
    public GameObject paytable;

    public bool isPaytableActive = false;

    public void TogglePaytable()
    {
        isPaytableActive = !isPaytableActive;
        paytable.SetActive(isPaytableActive);

        if (isPaytableActive == true)
        {
            FindObjectOfType<ButtonController>().multiGameButton.interactable = false;
            FindObjectOfType<ButtonController>().playButton.interactable = false;
            FindObjectOfType<ButtonController>().autoPlayButton.interactable = false;
        }
        else
        {
            FindObjectOfType<ButtonController>().multiGameButton.interactable = true;
            if (FindObjectOfType<GameManager>().CanSpin())
                FindObjectOfType<ButtonController>().playButton.interactable = true;
            FindObjectOfType<ButtonController>().autoPlayButton.interactable = true;
        }
        
    }
}
