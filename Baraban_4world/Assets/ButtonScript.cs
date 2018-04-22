using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonScript : MonoBehaviour, IVirtualButtonEventHandler {
	
	public GameObject Btn1;
	public GameObject Btn2;

	// Use this for initialization
	void Start () {
		Btn1 = GameObject.Find("VButton1");
		Btn2 = GameObject.Find("VButton2");
		Btn1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Btn2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

	}

}﻿