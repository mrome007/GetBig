using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGetBigPlayer : MonoBehaviour 
{

	[SerializeField]
	private float acceleration;
	[SerializeField]
	private float maxSpeed;
	private float speed;

	private void Start()
	{
		speed = 0f;
	}

	private void Update()
	{
		speed = MoveCamera();
		transform.Translate(Vector3.forward * speed);
	}

	private float MoveCamera()
	{
		var result = speed;
		result = result + acceleration * Time.deltaTime;
		if(result >= maxSpeed)
		{
			result = maxSpeed;
		}
		return result;
	}
}
