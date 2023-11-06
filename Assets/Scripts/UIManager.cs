using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject SuspectsGameObjects;

    void Start()
    {
        SuspectsGameObjects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DigitalsBtn()
    {
        SuspectsGameObjects.SetActive(true);
    }

}
