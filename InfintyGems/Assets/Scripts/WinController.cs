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

    void Start()
    {
        reelSymbols = FindObjectOfType<SymbolController>().symbolObject;
        symbols = FindObjectOfType<SymbolController>().symbols;
    }

    public void GameWon()
    {
        if (reelSymbols[0].GetComponent<SpriteRenderer>().sprite == symbols[0] && reelSymbols[3].GetComponent<SpriteRenderer>().sprite == symbols[0] && reelSymbols[6].GetComponent<SpriteRenderer>().sprite == symbols[0])
            Debug.Log($"3 x {symbols[0]} pays 30 credits");
    }

    public void TestData()
    {
        reelSymbols[1].GetComponent<SpriteRenderer>().sprite = symbols[1];
        reelSymbols[4].GetComponent<SpriteRenderer>().sprite = symbols[1];
        reelSymbols[7].GetComponent<SpriteRenderer>().sprite = symbols[1];
        reelSymbols[10].GetComponent<SpriteRenderer>().sprite = symbols[1];
        reelSymbols[13].GetComponent<SpriteRenderer>().sprite = symbols[1];
    }

}
