using System.Collections;
using UnityEngine;

public class MusicFade : MonoBehaviour
{
    public float fadeTime = 1f;

    private void Start()
    {
        StartCoroutine(FadeIn(fadeTime));
    }

    public void FadeOut(float time)
    {
        StartCoroutine(FadeOutMusic(time));
    }

    IEnumerator FadeIn(float time)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0f;
        audioSource.Play();

        while (audioSource.volume < 1)
        {
            audioSource.volume += Time.deltaTime / time;
            yield return null;
        }
    }

    IEnumerator FadeOutMusic(float time)
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        while (audioSource.volume > 0)
        {
            audioSource.volume -= Time.deltaTime / time;
            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = 1f;
    }
}
