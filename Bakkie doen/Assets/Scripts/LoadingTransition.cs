﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadingTransition : MonoBehaviour {
    //Image for the loading screen
    public Image theLoadingImage;
    //Speed for the rotation of the image
    public float imageRotateSpeed;
    //How long the loading screen should last
    public float loadingTime;
    //When to start a loading screen based on time in seconds
    public float timeToStartLoadingScreen;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //Rotates the image on the loading screen
        theLoadingImage.rectTransform.Rotate(new Vector3(0, imageRotateSpeed * Time.deltaTime, 0));
	}
}
