using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject coinFountainSpawner;

    void Start()
    {
        
        StartCoroutine("IUpdateBalance");
        
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
    }

    private IEnumerator IUpdateBalance()
    {
        yield return new WaitForSeconds(4f);
        float credits = 10000;
        Text[] sceneTexts = FindObjectsOfType<Text>();
        int textIndex = 0;
        int counter = 0;
        
        foreach(Text text in sceneTexts)
        {
            if (text.name == "PlayerPanelText")
                textIndex = counter;

            counter++;  
        }

        sceneTexts[textIndex].text = credits.ToString();
        print(credits);
    }

    public void Spin()
    {
        FindObjectOfType<SymbolController>().IsSpinning = true;
        FindObjectOfType<SymbolController>().Spin();
    }

    public void Stop()
    {
        FindObjectOfType<SymbolController>().IsSpinning = false;
        FindObjectOfType<SymbolController>().Stop();
    }
}
