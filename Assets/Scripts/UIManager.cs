using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] percentageTextResult; //array of game objects

    public GameObject[] personGameObject; //array of game objects

    void Start()
    {
        foreach (GameObject obj in percentageTextResult)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in personGameObject)
        {
            obj.SetActive(false);
        }

    }
    public void PersonBtn(int indexObj)
    {
        DisableAllPeople();
        personGameObject[indexObj].SetActive(true);
    }

    private void DisableAllPeople()
    {
        foreach (GameObject obj in personGameObject)
        {
            obj.SetActive(false);
        }
    }


}
