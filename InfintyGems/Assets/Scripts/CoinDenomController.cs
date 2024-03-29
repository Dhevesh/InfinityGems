﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDenomController : MonoBehaviour
{
    public Text coinDenomButtonText;


    private int denomIndex = 1;
    private int denomListSize;
    private List<int> denomList = new List<int>();

    private int denomValue;

    public int DenomValue { get => denomValue; }
    
    void Awake()
    {
        denomList.Add(1);
        denomList.Add(2);
        denomList.Add(5);
        denomList.Add(10);
        denomList.Add(25);
        denomList.Add(50);
        denomList.Add(100);
        denomList.Add(200);
        denomList.Add(500);
        denomList.Add(1000);
        denomListSize = denomList.Count;
        denomValue = denomList[0];
    }

    public void ChangeDenomination()
    {
        if (denomIndex >= 6)
        {
            coinDenomButtonText.text = $"${denomList[denomIndex].ToString()}";
        }
        else
        {
            coinDenomButtonText.text = $"{denomList[denomIndex].ToString()}¢";
            
        }
        denomValue = denomList[denomIndex];
        denomIndex++;
        if (denomIndex >= denomListSize)
            denomIndex = 0;
        
    }
}
