using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject coinFountainSpawner;
    [SerializeField]
    private Text playerBalance;

    public float credits = 0;

    void Start()
    {
        InsertCredits();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<CoinFountainController>().EnableCoinFountain();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            FindObjectOfType<CoinFountainController>().DisableCoinFountain();
        }

        if (credits == 0)
            FindObjectOfType<ButtonController>().playButton.interactable = false;
        else
            FindObjectOfType<ButtonController>().playButton.interactable = true;
    }

    private void InsertCredits()
    {
        //credits = 1000;
        playerBalance.text = credits.ToString();
        FindObjectOfType<ButtonController>().playButton.interactable = true;
    }

}
