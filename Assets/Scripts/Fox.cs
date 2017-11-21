using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Attacker))]
public class Fox : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		GameObject objectCollidedWith = otherObject.gameObject;

		if (!objectCollidedWith.GetComponent<Defender>())
		{
			return;
		}

		if (objectCollidedWith.GetComponent<Stone>())
		{
			animator.SetTrigger("jump trigger");
		}
		else
		{
			animator.SetBool("isAttacking", true);
			attacker.Attack(objectCollidedWith);
		}
	}
}
