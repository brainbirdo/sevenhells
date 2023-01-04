using Fungus;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CaveEntrance : MonoBehaviour
{
    public Image blackOverlay;
    public float fadeDuration = 2f;
    public GameObject DrawCharacter;

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed");
            StartCoroutine(FadeInAndMove());
        }
    }

    IEnumerator FadeInAndMove()
    {
        // Fade the Image in
        blackOverlay.CrossFadeAlpha(1f, fadeDuration, true);

        // Wait for the fade in to complete
        yield return new WaitForSeconds(fadeDuration);

        // Set the position of DrawCharacter
        DrawCharacter.transform.position = new Vector2(271.76f, -38.14f);

        // Fade the Image out
        blackOverlay.CrossFadeAlpha(0f, fadeDuration, true);
    }
}
