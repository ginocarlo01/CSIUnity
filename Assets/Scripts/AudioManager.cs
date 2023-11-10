using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] audioClips;

    UIManager uiMan;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        uiMan = GetComponent<UIManager>();
    }

    public void PlayAudio(int audioIndex)
    {
        StopAudio();
        AudioClip clip = audioClips[audioIndex];
        audioSource.clip = clip; 
        audioSource.Play();
        uiMan.AudioHasFinished(false, audioIndex);
        StartCoroutine(WaitAudioEnd(clip.length, audioIndex));
    }

    private void StopAudio()
    {
        audioSource.Stop();
    }

    IEnumerator WaitAudioEnd(float duration, int audioIndex)
    {
        yield return new WaitForSeconds(duration);
        uiMan.AudioHasFinished(true, audioIndex);
    }
}
