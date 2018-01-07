using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

	public bool isRotating = true;
	public float rotateSpeed = 10f;
	public bool randomStartingRotation = false;

	// Use this for initialization
	void Start ()
	{
		if (randomStartingRotation)
		{
			float randomMultiplier = Random.Range (0, 360);
			transform.Rotate (new Vector3(0,1,0) * rotateSpeed * randomMultiplier, Space.World);
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (isRotating)
		{
			transform.Rotate (new Vector3(0,1,0) * rotateSpeed * Time.deltaTime, Space.World);
		}	
	}

	//Stops this gameobject's rotation
	public void StopRotating()
	{
		isRotating = false;
	}

	//Starts this gameobject's rotation
	public void StartRotating()
	{
		isRotating = true;
	}
}
