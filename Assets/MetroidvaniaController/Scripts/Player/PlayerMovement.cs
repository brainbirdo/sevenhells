using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public KeyCode[] interactonKeys;

	public Flowchart flowchart;

	public Interactable currentInteractable;
	public bool inDialogue;

	public Attack attack;

	public float runSpeed = 40f;

	public float horizontalMove = 0f;
	bool jump = false;
	public bool canJump;
	bool dash = false;

    //bool dashAxis = false;

    private void Start()
    {
        canJump = true;
    }

	public void Jump(bool value)
    {
		canJump = value;
    }

    // Update is called once per frame
    void Update ()
	{
        if (!inDialogue)
        {
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetKeyDown(KeyCode.Space))
            {
				if(canJump)
                {
					jump = true;
				}
            }

            if (Input.GetKeyDown(KeyCode.F))
			{
				dash = true;
			}

			/*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
			{
				if (dashAxis == false)
				{
					dashAxis = true;
					dash = true;
				}
			}
			else
			{
				dashAxis = false;
			}
			*/
			Interact();
		}
		
		if (inDialogue)
        {
			jump = false;
			dash = false;
			horizontalMove = 0f;
			animator.SetFloat("Speed", 0f);
			attack.canAttack = false;
			
        }

	}

	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		jump = false;
		dash = false;
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
		Interactable interactable = collision.GetComponent<Interactable>();
		if (interactable)
        {
			currentInteractable = interactable;
        }
    }

	private void OnTriggerExit2D(Collider2D collision)
	{
		currentInteractable = null;
	}
	private void Interact()
    {
		if (!currentInteractable) { return; }
		foreach(KeyCode keyCode in interactonKeys)
        {
			if(Input.GetKeyDown(keyCode))
            {
				flowchart.ExecuteBlock(currentInteractable.blockName);
				inDialogue = true;
            }
        }
    }
	public void ExitBlock()
    {
		inDialogue = false;
		attack.canAttack = true;
    }
}
