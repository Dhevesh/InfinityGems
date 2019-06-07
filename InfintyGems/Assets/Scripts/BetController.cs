using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetController
{

    [SerializeField]
    private Text coinDenomButtonText;

    private int index = 1;
    int denomListSize;
    private List<int> denoms = new List<int>();



    void Awake()
    {
        denoms.Add(1);
        denoms.Add(2);
        denoms.Add(5);
        denoms.Add(10);
        denoms.Add(25);
        denoms.Add(50);
        denoms.Add(100);
        denoms.Add(200);
        denoms.Add(500);
        denoms.Add(1000);

        denomListSize = denoms.Count;
    }

    public void ChangeDenomination()
    {
        string symbol;
        if (index >= 6)
        {
            symbol = "$";
            coinDenomButtonText.text = $"${denoms[index].ToString()}";
        }
        else
        {
            symbol = "c";
            coinDenomButtonText.text = $"{denoms[index].ToString()}c";
        }
        index++;
        if (index >= denomListSize)
            index = 0;
    }

}
