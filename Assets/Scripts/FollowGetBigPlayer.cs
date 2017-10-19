using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGetBigPlayer : MonoBehaviour 
{
	[SerializeField]
	private GetBigMovement getBigMovement;

	[SerializeField]
	private float acceleration;

	[SerializeField]
	private float maxSpeed;

	private float speed;

	private void Start()
	{
		speed = 0f;
		getBigMovement.SpeedChanged += HandleSpeedChanged;
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

	private void HandleSpeedChanged(object sender, GetBigSpeedArgs e)
	{
		maxSpeed = e.Speed;
	}
}
