using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using UnityEngine.UI;

public class ViewCycler : MonoBehaviour {

	public GameObject[] cycleTargets;	//the gameobjects to cycle through. Set them in editor.
	private int cycleTargetIndex = 0;	//index to help keep track of cycling.
	public Text cycleName;	//the ui text object that has current cycleable item's name.

	// Use this for initialization
	void Start ()
	{
		cycleName.text = cycleTargets [cycleTargetIndex].name;	
	}

	// Cycles to the next cycleable gameobject defined in cycleTargets array.
	public void CycleNext()
	{
		//disable current cycleable item
		cycleTargets[cycleTargetIndex].SetActive (false);
		//increase cycle target index or reset to zero if at the end of cycle target array
		if (cycleTargetIndex < cycleTargets.Length-1) {
			cycleTargetIndex++;
		}
		else
		{
			cycleTargetIndex = 0;
		}
		//activate next cyclable item
		cycleTargets[cycleTargetIndex].SetActive (true);
		//change correct name text
		cycleName.text = cycleTargets [cycleTargetIndex].name;	
	}

	// Cycles to the previous cycleable gameobject defined in cycleTargets array.
	public void CyclePrevious()
	{
		//disable current cycleable item
		cycleTargets[cycleTargetIndex].SetActive (false);
		//decrease cycle target index or set to cycle targets' last index position if current target is at pos zero
		if (cycleTargetIndex > 0) {
			cycleTargetIndex--;
		}
		else
		{
			cycleTargetIndex = cycleTargets.Length-1;
		}
		//activate next cyclable item
		cycleTargets[cycleTargetIndex].SetActive (true);
		//change correct name text
		cycleName.text = cycleTargets [cycleTargetIndex].name;	
	}
}
