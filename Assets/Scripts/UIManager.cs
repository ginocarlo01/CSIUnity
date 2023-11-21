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
    public Animator[] SFXBtn;

    [SerializeField]
    public Sprite playBtn;

    [SerializeField]
    public Sprite waveSoundBtn;

    [SerializeField]
    public GameObject wrongAnswer;

    [SerializeField]
    public GameObject rightAnswer;


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

        DisableAllAnswers();

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
            SFXBtn[index].SetBool("playing", false);
        }
        else
        {
            SFXBtn[index].SetBool("playing", true);
        }
    }

    public void FinishAllAudioAnimation()
    {
        for(int i = 0; i < SFXBtn.Length; i++)
        {
            SFXBtn[i].SetBool("playing", false) ;
        }
    }

    public void DisableAllAnswers()
    {
        wrongAnswer.SetActive(false);
        rightAnswer.SetActive(false);
    }

    public void RightAnswer()
    {
        rightAnswer.SetActive(true);
        wrongAnswer.SetActive(false) ;

    }

    public void WrongAnswer()
    {
        rightAnswer.SetActive(false);
        wrongAnswer.SetActive(true);
    }

}
