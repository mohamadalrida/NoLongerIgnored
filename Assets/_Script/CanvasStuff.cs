using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStuff : MonoBehaviour {

    public GameObject canvasEGO;
    public GameObject canvas;


	// Use this for initialization
	void Start () {

        canvasEGO.GetComponent<BoxCollider>();
        canvas.GetComponent<UIFaderIn>();
	}
	
	// Update is called once per frame
	void Update () {
        canvasEGO.GetComponent<BoxCollider>().enabled = false;
        canvas.GetComponent<UIFaderIn>().enabled = true;
	}
}
