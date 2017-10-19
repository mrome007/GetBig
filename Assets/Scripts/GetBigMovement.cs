using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBigMovement : MonoBehaviour 
{
	[SerializeField]
	private float MaxSpeed = 5f;
	[SerializeField]
	private float Acceleration = 1f;

	private float horizontalSpeed;
	private float verticalSpeed;
	private Vector3 movementVector;

	private void Start()
	{
		horizontalSpeed = 0f;
		verticalSpeed = 0f;
		movementVector = Vector3.forward;
	}

	private void Update()
	{
		horizontalSpeed = AcceleratedMovement(horizontalSpeed);
		transform.Translate(movementVector * horizontalSpeed);
	}

	private float AcceleratedMovement(float speed)
	{
		float result = speed;
		result = result + Acceleration * Time.deltaTime;
		if(result >= MaxSpeed)
		{
			result = MaxSpeed;
		}
		return result;
	}

	public void SetMaxSpeed(float newSpeed)
	{
		MaxSpeed = newSpeed < 0.1f ? 0.1f : newSpeed;
	}
}
