using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleHealth : MonoBehaviour
{
    public bool doubleHealth;

    void Start()
    {
        doubleHealth= false;
    }

    public void DoubleHealthActive()
    {
        doubleHealth = true;
    }
}
