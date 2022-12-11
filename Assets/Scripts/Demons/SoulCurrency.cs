using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SoulCurrency : MonoBehaviour
{
    public Enemy enemy;
    public Flowchart flowchart;
    public float enemyHealth;

    void Start()
    {
        flowchart.GetFloatVariable("Souls");
    }

    void Update()
    {
        enemyHealth = (enemy.life);

        if (enemyHealth <= 0)
        {
            CurrencyAdd();
        }
    }

    public void CurrencyAdd()
    {
        flowchart.SetFloatVariable("Souls", + 1f);
    }

}
