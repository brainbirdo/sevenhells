using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class LowVision : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    public void FogOn()
    {
        spriteRenderer.enabled = true;

    }

    public void FogOff()
    {
        spriteRenderer.enabled = false;
    }

}
