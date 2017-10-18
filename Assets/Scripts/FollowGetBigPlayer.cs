using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGetBigPlayer : MonoBehaviour 
{
	public Transform GetBigPlayerTransform;

	private Vector3 offset;
	private Vector3 movementVector;

	private void Start()
	{
		offset = GetBigPlayerTransform.position - transform.position;
		movementVector = transform.position;
	}

	private void LateUpdate()
	{
		var newPos = GetBigPlayerTransform.position + offset;
		movementVector.z = newPos.z;
		transform.position = movementVector;
	}
}
