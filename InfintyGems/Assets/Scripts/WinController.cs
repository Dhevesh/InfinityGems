using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] row1;
    [SerializeField]
    private GameObject[] row2;
    [SerializeField]
    private GameObject[] row3;

    private GameObject[] reelSymbols;
    private Sprite[] symbols;
    private List<SpriteRenderer> sr = new List<SpriteRenderer>();

    public List<string> infoBarMessages = new List<string>();

    void Start()
    {
        reelSymbols = FindObjectOfType<SymbolController>().symbolObject;
        symbols = FindObjectOfType<SymbolController>().symbols;
        GetSpriteRenderer();
    }

    public void GameWon()
    {
        infoBarMessages.Clear();
        for (int i = 0; i < symbols.Length; i++)
        {
            //Payline1
            if (sr[1].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[10].sprite == symbols[i] && sr[13].sprite == symbols[i])
                infoBarMessages.Add("Payline 1 : 5 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[10].sprite == symbols[i])
                infoBarMessages.Add("Payline 1 : 4 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[7].sprite == symbols[i])
                infoBarMessages.Add("Payline 1 : 3 of Kind");
            //Payline2
            if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[9].sprite == symbols[i] && sr[12].sprite == symbols[i])
                infoBarMessages.Add("Payline 2: 5 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[9].sprite == symbols[i])
                infoBarMessages.Add("Payline 2: 4 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i])
                infoBarMessages.Add("Payline 2: 3 of Kind");
            //Payline3
            if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[11].sprite == symbols[i] && sr[14].sprite == symbols[i])
                infoBarMessages.Add("Payline 3: 5 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[11].sprite == symbols[i])
                infoBarMessages.Add("Payline 3: 4 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i])
                infoBarMessages.Add("Payline 3: 3 of Kind");
            //Payline4
            if (sr[0].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[10].sprite == symbols[i] && sr[12].sprite == symbols[i])
                infoBarMessages.Add("Payline 4: 5 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[10].sprite == symbols[i])
                infoBarMessages.Add("Payline 4: 4 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[8].sprite == symbols[i])
                infoBarMessages.Add("Payline 4: 3 of Kind");
            //Payline5
            if (sr[2].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[10].sprite == symbols[i] && sr[14].sprite == symbols[i])
                infoBarMessages.Add("Payline 5: 5 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[10].sprite == symbols[i])
                infoBarMessages.Add("Payline 5: 4 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[4].sprite == symbols[i] && sr[6].sprite == symbols[i])
                infoBarMessages.Add("Payline 5: 3 of Kind");
            //Payline6
            if (sr[1].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[9].sprite == symbols[i] && sr[13].sprite == symbols[i])
                infoBarMessages.Add("Payline 6: 5 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i] && sr[9].sprite == symbols[i])
                infoBarMessages.Add("Payline 6: 4 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[6].sprite == symbols[i])
                infoBarMessages.Add("Payline 6: 3 of Kind");
            //Payline7
            if (sr[1].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[11].sprite == symbols[i] && sr[13].sprite == symbols[i])
                infoBarMessages.Add("Payline 7 : 5 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i] && sr[11].sprite == symbols[i])
                infoBarMessages.Add("Payline 7 : 4 of Kind");
            else if (sr[1].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[8].sprite == symbols[i])
                infoBarMessages.Add("Payline 7 : 3 of Kind");
            //Payline8
            if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[11].sprite == symbols[i] && sr[14].sprite == symbols[i])
                infoBarMessages.Add("Payline 8: 5 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[11].sprite == symbols[i])
                infoBarMessages.Add("Payline 8: 4 of Kind");
            else if (sr[0].sprite == symbols[i] && sr[3].sprite == symbols[i] && sr[7].sprite == symbols[i])
                infoBarMessages.Add("Payline 8: 3 of Kind");
            //Payline9
            if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[9].sprite == symbols[i] && sr[12].sprite == symbols[i])
                infoBarMessages.Add("Payline 9: 5 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[7].sprite == symbols[i] && sr[9].sprite == symbols[i])
                infoBarMessages.Add("Payline 9: 4 of Kind");
            else if (sr[2].sprite == symbols[i] && sr[5].sprite == symbols[i] && sr[7].sprite == symbols[i])
                infoBarMessages.Add("Payline 9: 3 of Kind");
        }
        
    }

    void GetSpriteRenderer()
    {         
        foreach (GameObject o in reelSymbols)
        {
            sr.Add(o.GetComponent<SpriteRenderer>());
        }
    }

    public void TestData()
    {
        //reelSymbols[1].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[4].GetComponent<SpriteRenderer>().sprite = symbols[2];
        //reelSymbols[7].GetComponent<SpriteRenderer>().sprite = symbols[3];
        //reelSymbols[10].GetComponent<SpriteRenderer>().sprite = symbols[4];
        //reelSymbols[13].GetComponent<SpriteRenderer>().sprite = symbols[5];

        //reelSymbols[0].GetComponent<SpriteRenderer>().sprite = symbols[2];
        //reelSymbols[3].GetComponent<SpriteRenderer>().sprite = symbols[2];
        //reelSymbols[6].GetComponent<SpriteRenderer>().sprite = symbols[2];
        //reelSymbols[9].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[12].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[2].GetComponent<SpriteRenderer>().sprite = symbols[5];
        //reelSymbols[5].GetComponent<SpriteRenderer>().sprite = symbols[5];
        //reelSymbols[8].GetComponent<SpriteRenderer>().sprite = symbols[5];
        //reelSymbols[11].GetComponent<SpriteRenderer>().sprite = symbols[5];
        //reelSymbols[14].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[0].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[4].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[8].GetComponent<SpriteRenderer>().sprite = symbols[4];
        //reelSymbols[10].GetComponent<SpriteRenderer>().sprite = symbols[4];
        //reelSymbols[12].GetComponent<SpriteRenderer>().sprite = symbols[4];

        //reelSymbols[2].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[4].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[6].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[10].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[14].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[1].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[3].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[6].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[9].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[13].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[1].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[5].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[8].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[11].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[13].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[0].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[3].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[7].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[11].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[14].GetComponent<SpriteRenderer>().sprite = symbols[1];

        //reelSymbols[2].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[5].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[7].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[9].GetComponent<SpriteRenderer>().sprite = symbols[1];
        //reelSymbols[12].GetComponent<SpriteRenderer>().sprite = symbols[1];
    }

}
