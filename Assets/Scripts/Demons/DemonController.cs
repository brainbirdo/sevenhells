using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonController : MonoBehaviour
{
    public bool Visible;

    // Start is called before the first frame update
    void Start()
    {
        Visible = true;
        gameObject.SetActive(true);
    }

    public void Vapeaway()
    {
        Visible = false;
        gameObject.SetActive(false);
    }
}

