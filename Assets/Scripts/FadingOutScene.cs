using UnityEngine;
using UnityEngine.UI;

public class FadingOutScene : MonoBehaviour
{
    public Image blackOverlay;
    public float fadeOutDuration = 2f;

    void Start()
    {
        // Fade out the black overlay over time
        blackOverlay.CrossFadeAlpha(0f, fadeOutDuration, true);

        // Set the black overlay as inactive after it has finished fading out
        Invoke("SetInactive", fadeOutDuration);
    }

    void SetInactive()
    {
        blackOverlay.gameObject.SetActive(false);
    }
}
