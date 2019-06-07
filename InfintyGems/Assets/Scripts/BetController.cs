using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetController:MonoBehaviour
{

    [SerializeField]
    private Text betText;
    [SerializeField]
    private int betStep = 0;
    [SerializeField]
    private int maxBet = 250;

    
    private int betIndex = 0;
    private int betListSize;
    private List<int> betList = new List<int>();



    void Awake()
    {
        FillBet();
        betListSize = betList.Count;
    }

    void Start()
    {
        betText.text = betList[0].ToString();
    }
    public void IncreaseBet()
    {
        
        if (betIndex >= (betListSize-1))
            betIndex = 0;
        else
            betIndex++;
        betText.text = betList[betIndex].ToString();
    }

    public void DecreaseBet()
    {
        
        if (betIndex == 0)
            betIndex = (betListSize - 1);
        else
            betIndex--;
        betText.text = betList[betIndex].ToString();

    }

    private void FillBet()
    {
        for (int i = betStep; i <= maxBet; i += betStep)
        {
            betList.Add(i);
        }
        
    }

}
