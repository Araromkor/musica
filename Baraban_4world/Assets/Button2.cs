using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button2 : MonoBehaviour, IVirtualButtonEventHandler {
	public AudioClip Clip;
	public AudioSource ASource;
	public GameObject Btn1;
	public GameObject Btn2;

	// Use this for initialization
	void Start () {
		Btn1 = GameObject.Find("VButton1");
		Btn2 = GameObject.Find("VButton2");
		Btn1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Btn2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		ASource = GetComponent<AudioSource> ();
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		ASource.clip = Clip;
		ASource.Play ();
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

	}

}﻿