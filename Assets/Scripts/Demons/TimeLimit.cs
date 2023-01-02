using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    public float time = 60f;

    public TextMeshProUGUI timerText;
    public CharacterController2D characterController;
    public GameObject heartsObject;
    public GameObject textObject;

    public bool timerOn = false;

    public void Start()
    {
        textObject.SetActive(false);
    }
    public void TimerStart()
    {
        time -= Time.deltaTime;

        timerText.text = time.ToString("F2");


        if (time <= 0f)
        {
            PlayerDead();
            timerText.text = "";
        }
    }

    public void PlayerDead()
    {
        characterController.StartCoroutine(characterController.WaitToDead());
    }

    void FixedUpdate()
    {
        if (timerOn)
        {
            TimerStart();
        }
    }

    public void TimerTrue()
    {
        timerOn = true;
        heartsObject.SetActive(false);
        textObject.SetActive(true);
    }
}
