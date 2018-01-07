using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {

	public bool isRotating = true;
	public float rotateSpeed = 1f;
	private Renderer rend;

	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isRotating)
		{
			transform.Rotate (new Vector3(0,1,0) * rotateSpeed * Time.deltaTime, Space.World);
		}	
	}

	public void StopRotating()
	{
		isRotating = false;
	}

	public void StartRotating()
	{
		isRotating = true;
	}
}
