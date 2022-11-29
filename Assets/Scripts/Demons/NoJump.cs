using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class NoJump : MonoBehaviour
{
    public CharacterController2D controller;
    public void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }

    public void JumpDisabled()
    {
        controller.canDoubleJump = false;

    }

}
