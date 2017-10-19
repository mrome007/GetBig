using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBigSpeedArgs : EventArgs
{
	public float Speed { get; private set; }

	public GetBigSpeedArgs(float newSpeed)
	{
		Speed = newSpeed;
	}
}
