using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] percentageTextResult;

    [SerializeField]
    public GameObject[] personGameObject;

    [SerializeField]
    public GameObject[] listenersGameObject;

    [SerializeField]
    public Image[] SFXBtn;

    [SerializeField]
    public Sprite playBtn;

    [SerializeField]
    public Sprite waveSoundBtn;

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

        DisableAllListeners();

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

    public void ListenerBtn(int indexObj)
    {
        DisableAllListeners();
        listenersGameObject[indexObj].SetActive(true);
    }

    private void DisableAllListeners()
    {
        foreach (GameObject obj in listenersGameObject)
        {
            obj.SetActive(false);
        }
    }

    public void AudioHasFinished(bool finished, int index)
    {
        if (finished)
        {
            SFXBtn[index].sprite = playBtn;
        }
        else
        {
            SFXBtn[index].sprite = waveSoundBtn;
        }
    }

}
