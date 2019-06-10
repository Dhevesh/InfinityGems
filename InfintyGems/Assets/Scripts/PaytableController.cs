using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaytableController : MonoBehaviour
{
    public GameObject paytable;

    bool isActive = false;

    public void TogglePaytable()
    {
        isActive = !isActive;
        paytable.SetActive(isActive);
    }
}
