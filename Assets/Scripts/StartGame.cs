using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject musicGameObject;
    public float fadeTime = 1f;
    public MusicFade musicFade;

    public Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        fadeImage.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(FadeAndLoadScene(1));
            musicFade.FadeOut(fadeTime);
        }
    }

    IEnumerator FadeAndLoadScene(int sceneIndex)
    {
        // Fade to black
        float elapsedTime = 0f;
        Color fadeColor = fadeImage.color;
        while (elapsedTime < fadeTime)
        {
            fadeColor.a = Mathf.Clamp01(elapsedTime / fadeTime);
            fadeImage.color = fadeColor;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Load the next scene
        SceneManager.LoadScene(sceneIndex);
    }
}
