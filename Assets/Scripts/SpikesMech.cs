using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesMech : MonoBehaviour
{
    public GameObject player;
    public DoubleHealth doubleHealth;
    public float bounceForce = 10.0f;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (doubleHealth.doubleHealth)
            {
                collision.gameObject.GetComponent<CharacterController2D>().ApplyDamage(1f, transform.position);
            }
            else
            {
                collision.gameObject.GetComponent<CharacterController2D>().ApplyDamage(2f, transform.position);
            }
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
