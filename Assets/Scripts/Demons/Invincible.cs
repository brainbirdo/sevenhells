using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class Invincible : MonoBehaviour
{
    public CharacterController2D controller;

    public void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }

    public void Invincibility()
    {
        controller.invincible = true;
    }

}
