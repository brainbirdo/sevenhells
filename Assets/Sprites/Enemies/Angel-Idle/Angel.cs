using UnityEngine;

public class Angel : MonoBehaviour
{
    public float speed;

    public int damage;

    private Transform enemyTransform;
    private Vector3 startPosition;

    private float distance = 4.0f;

    private int direction = 1;

    public DoubleHealth doubleHealth;
    public GameObject player;



    void Start()
    {
        // Get the transform component of the enemy
        enemyTransform = GetComponent<Transform>();

        // Save the starting position of the enemy
        startPosition = enemyTransform.position;
    }

    void Update()
    {
        // Calculate the new position of the enemy
        Vector3 newPosition = startPosition;
        newPosition.y += direction * distance * Mathf.Sin(Time.time * speed);

        // Update the enemy's position
        enemyTransform.position = newPosition;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (doubleHealth.doubleHealth)
            {
                player.GetComponent<CharacterController2D>().ApplyDamage(1f, transform.position);
            }
            else
            {
                player.GetComponent<CharacterController2D>().ApplyDamage(2f, transform.position);
            }
        }
    }
}
