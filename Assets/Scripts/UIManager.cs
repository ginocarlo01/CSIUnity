using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] suspectsGameObjects; //array of game objects

    void Start()
    {
        foreach (GameObject obj in suspectsGameObjects)
        {
            obj.SetActive(false);
        }
        
    }

    

}
