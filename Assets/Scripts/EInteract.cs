using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EInteract : MonoBehaviour
{
    // The GameObject to unhide when the player is in range.
    public GameObject objectToUnhide;

    // The range at which the player is considered to be in range of the enemy.
    public float range = 10f;

    // The Transform component of the player.
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the enemy and the player.
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // If the distance is less than or equal to the range, unhide the object.
        if (distance <= range)
        {
            objectToUnhide.SetActive(true);
        }
        else
        {
            // Otherwise, hide the object.
            objectToUnhide.SetActive(false);
        }
    }
}