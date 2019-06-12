using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SymbolController : MonoBehaviour
{
    
    public Sprite[] symbols;

    private bool isSpinning;
    private int randomIndex;
    [HideInInspector]
    public GameObject[] symbolObject;

    float count = 0f;


    public bool IsSpinning
    {
        get => this.isSpinning;
        set => this.isSpinning = value;
    }
    void Awake()
    {
        
        symbolObject = GameObject.FindGameObjectsWithTag("Symbol").OrderBy(go=>go.name).ToArray();
        //FindObjectOfType<WinController>().reelSymbols = symbolObject;
        GetSymbols();

    }

    void Update()
    {
        if (count >= 20f)
        {
            isSpinning = false;
            FindObjectOfType<ButtonController>().stopButton.gameObject.SetActive(false);
            FindObjectOfType<ButtonController>().playButton.gameObject.SetActive(true);
            count = 0f;
        }
    }

    public void Spin()
    {
        isSpinning = true;
        StartCoroutine(ISpawnSymbols());
    }

    public void Stop()
    {
        isSpinning = false;
        StopCoroutine(ISpawnSymbols());
        count = 0f;
    }
    public IEnumerator ISpawnSymbols()
    {
        while (isSpinning)
        {
            yield return new WaitForSeconds(0.08f);
            GetSymbols();
            count++;
        }
        //This needs to move into the GameManager
        FindObjectOfType<WinController>().TestData();
        FindObjectOfType<WinController>().GameWon();
        foreach (string s in FindObjectOfType<WinController>().infoBarMessages)
        {
            FindObjectOfType<InfoBarController>().infoBarText.text = s;
            yield return new WaitForSecondsRealtime(3f);
        }
    }

    private void GetSymbols()
    {
        foreach (GameObject o in symbolObject)
        {
            randomIndex = Random.Range(0, symbols.Length);
            o.GetComponent<SpriteRenderer>().sprite = symbols[randomIndex];
        }

        //symbolObject[12].GetComponent<SpriteRenderer>().sprite = symbols[1]; FOR TESTING
    }

}
