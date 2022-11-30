using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class LowVision : MonoBehaviour
{
    public bool fogOn = false;

    void Start()
    {
        fogOn = false;

    }

    public void Fog()
    {
        if (fogOn)
        {
            gameObject.SetActive(true);
        }
      
        if (!fogOn)
        {
            gameObject.SetActive(false);
        }
    }

}
