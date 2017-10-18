using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBig : MonoBehaviour 
{
	public int MaxResources;
	public int Resources;

	private float scale = 0.25f;
	private Vector3 scaleFactor;
	private GetBigMovement getBigMovement;

	private float smolScale = 0.1f;
	private Vector3 smolScaleFactor;

	private void Awake()
	{
		//control speed and acceleration when scaling up or down.
		getBigMovement = GetComponent<GetBigMovement>();
	}

	private void Start()
	{
		scaleFactor = Vector3.one * scale;
		smolScaleFactor = Vector3.one * smolScale;
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.M))
		{
			GetBiggie();
		}
		if(Input.GetKey(KeyCode.N))
		{
			GetSmol();
		}
	}

	private void GetBiggie()
	{
		if(Resources > 0)
		{
			transform.localScale += scaleFactor;
			Resources--;
		}
	}

	private void GetSmol()
	{
		if(transform.localScale.x > 0.1f)
		{
			transform.localScale -= smolScaleFactor;
		}
		else
		{
			transform.localScale = smolScaleFactor;
		}
	}

}
