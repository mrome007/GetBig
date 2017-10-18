using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBigMovement : MonoBehaviour 
{
	public float MaxSpeed = 5f;
	public float Acceleration = 1f;

	private float horizontalSpeed;
	private float verticalSpeed;
	private Vector3 movementVector;

	private void Start()
	{
		horizontalSpeed = 0f;
		verticalSpeed = 0f;
		movementVector = Vector3.zero;
	}

	private void Update()
	{
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");
		horizontalSpeed = AcceleratedMovement(h, horizontalSpeed);
		movementVector.x = horizontalSpeed;
		transform.Translate(movementVector);
	}

	private float AcceleratedMovement(float axis, float speed)
	{
		float result = speed;
		//move with acceleration
		if(axis != 0)
		{
			var resultSpeed = result + (axis * Acceleration * Time.deltaTime);
			if(Mathf.Abs(resultSpeed) < MaxSpeed)
			{
				result = result + (axis * Acceleration * Time.deltaTime);
			}
			else
			{
				result = MaxSpeed * axis;
			}
		}
		//stop and decelerate.
		else
		{
			var sign = Mathf.Sign(result);
			if(Mathf.Abs(result) > 0.01)
			{
				result = result + (-sign * Acceleration * Time.deltaTime);
			}
			else
			{
				result = 0f;
			}
		}
		return result;
	}
}
