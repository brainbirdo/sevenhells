using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SoulCurrency : MonoBehaviour
{
    public static SoulCurrency instance;

    public Flowchart flowchart;
    public float souls;

    public Enemy enemy;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        souls = flowchart.GetFloatVariable("Souls");
    }

    void Update()
    {
        flowchart.SetFloatVariable("Souls", souls);
    }

    public void AddSoul()
    {
        souls += 1;
    }
}
