using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonController : MonoBehaviour
{
    public bool Visible;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    public void Vapeaway()
    {
        gameObject.SetActive(false);
    }
}

