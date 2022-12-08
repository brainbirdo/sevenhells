using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float playerHealth;
    public CharacterController2D controller;

    [SerializeField] private Image[] hearts;

    private void Start()
    {
        UpdateHealth();
    }


    public void Update()
    {
        playerHealth = controller.life;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.white;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
}
    