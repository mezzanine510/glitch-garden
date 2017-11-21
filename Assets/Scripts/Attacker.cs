using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour 
{
	private float walkSpeed;
	private GameObject currentTarget;

	void Start () 
	{

	}

	void Update () 
	{
		transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D()
	{
		Debug.Log(name + " trigger enter");
	}

	public void SetWalkSpeed(float speed)
	{
		walkSpeed = speed;
	}

	// Called from the animator at the time of actual blow
	public void StrikeCurrentTarget(float damage)
	{
		Debug.Log(name + " has done dealt damage: " + damage);
	}

	public void Attack(GameObject obj)
	{
		currentTarget = obj;
	}
}
