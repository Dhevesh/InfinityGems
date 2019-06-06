using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    
    void Start()
    {
        DetectAndActivateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DetectAndActivateDisplay()
    {
        foreach (Display display in Display.displays)
        {
            display.Activate();
        }
    }
}
