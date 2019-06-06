using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolController : MonoBehaviour
{
    
    public Sprite[] symbols;

    private bool isSpinning;
    private int randomIndex;
    [HideInInspector]
    public GameObject[] symbolObject;


    public bool IsSpinning
    {
        get => this.isSpinning;
        set => this.isSpinning = value;
    }
    void Awake()
    {
        
        symbolObject = GameObject.FindGameObjectsWithTag("Symbol");
        GetSymbols();

    }

    public void Spin()
    {
        StartCoroutine(ISpawnSymbols());
    }

    public void Stop()
    {
        StopCoroutine(ISpawnSymbols());
    }
    public IEnumerator ISpawnSymbols()
    {
        while (isSpinning)
        {
            yield return new WaitForSeconds(0.08f);
 
            GetSymbols();
        }
    }

    private void GetSymbols()
    {
        foreach (GameObject o in symbolObject)
        {
            randomIndex = Random.Range(0, symbols.Length);
            o.GetComponent<SpriteRenderer>().sprite = symbols[randomIndex];
        }
    }

}
