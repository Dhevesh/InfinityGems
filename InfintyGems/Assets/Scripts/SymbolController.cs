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

    float count = 0f;


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
        StartCoroutine(ISpawnSymbols());
    }

    public void Stop()
    {
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
