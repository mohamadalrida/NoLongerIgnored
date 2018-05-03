using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStuff : MonoBehaviour {

    public GameObject canvasEGO;
    public GameObject canvas;
    public AudioSource listener;
    public AudioClip music;
    public GameObject[] lantern60;


    // Use this for initialization
    void Start () {

        canvasEGO.GetComponent<BoxCollider>();
        canvas.GetComponent<UIFaderIn>();
        listener = GetComponent<AudioSource>();
        StartCoroutine(WaitToFloat());

    }
	
	// Update is called once per frame
	void Update () {

        canvasEGO.GetComponent<BoxCollider>().enabled = false;
        canvas.GetComponent<UIFaderIn>().enabled = true;
        listener.GetComponent<AudioSource>().enabled = true;
        listener.PlayOneShot(music);
    }

    IEnumerator WaitToFloat()
    {
        yield return new WaitForSecondsRealtime(50);
        lantern60[0].GetComponent<move2>().enabled = true;
        lantern60[1].GetComponent<move2>().enabled = true;
        lantern60[2].GetComponent<move2>().enabled = true;
        lantern60[3].GetComponent<move2>().enabled = true;
        lantern60[4].GetComponent<move2>().enabled = true;
        lantern60[5].GetComponent<move2>().enabled = true;
        lantern60[6].GetComponent<move2>().enabled = true;
        lantern60[7].GetComponent<move2>().enabled = true;
        lantern60[8].GetComponent<move2>().enabled = true;
        lantern60[9].GetComponent<move2>().enabled = true;
    }
}
