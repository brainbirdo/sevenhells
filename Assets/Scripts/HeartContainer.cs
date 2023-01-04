using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartContainer : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colliding with heart");
        if (other.gameObject.tag == "Player" && player.GetComponent<CharacterController2D>().life < 10)
        {
            player.GetComponent<CharacterController2D>().ApplyHealing();
            gameObject.SetActive(false);
        }
    }
}
