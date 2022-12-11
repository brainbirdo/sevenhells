using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBackwards : MonoBehaviour
{

    public bool canBackwards;
    public PlayerMovement playerMovement;

    void Update()
    {
        if (!canBackwards)
        {
            playerMovement.horizontalMove = Mathf.Clamp(playerMovement.horizontalMove, 0, 40);
        }
    }

    public void BackwardsOff()
    {
        canBackwards= false;
    }

    private void Start()
    {
        canBackwards = true;
    }

}
