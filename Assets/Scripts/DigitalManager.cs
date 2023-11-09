using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalManager : MonoBehaviour
{
    public void DigitalsBtn(int indexObj)
    {
        UIManager uiObj = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

        uiObj.suspectsGameObjects[indexObj].SetActive(true);
    }
}
