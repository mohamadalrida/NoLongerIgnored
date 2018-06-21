﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Releaser : MonoBehaviour {

    //Used to "Release" the lantern and turn on and off a few things 
    
    public GameObject canvas;
    public GameObject release;
    public CanvasGroup main;
    public CanvasGroup second;
    public float mainalpha;
    public float secondalpha;
    public GameObject fader;
    public AudioSource music;
    private float musicTime;
    private float f;
    private float d;
    private float e;
    
	// Use this for initialization
	void Start () {

        //instantiate alpha of texts and the music 
        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;
        musicTime = music.volume;
    }
	
	// Update is called once per frame
	void Update () {

        //updates the alpha 
        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;

        //sets Release text EGO to active which instantiates a fade in script
        release.SetActive(true);

        d += Time.deltaTime;

        if (d >= 90)
        {
            musicTime -= Time.deltaTime / 8;
            fader.SetActive(true);
            music.volume = musicTime;
            
            e += Time.deltaTime;
            if (e >= 15)
            {
                Application.Quit();
            }
        }

        if (secondalpha == 1f)
        {
            ReleasePls();
        }
	}

    private void ReleasePls()
    {
<<<<<<< HEAD
        f += Time.deltaTime;
        
        if (f >= 8)
        {
            release.GetComponent<UIFader>().enabled = true;
        }   
            
=======
        Debug.Log("before time");
        yield return new WaitForSecondsRealtime(80);
        Debug.Log("after time");
        musicTime -= Time.deltaTime / 4;
        fader.SetActive(true);
        music.volume = musicTime;
>>>>>>> parent of cee03a3... Actual Open Night build
    }

    //IEnumerator Releasing()
    //{
    //   //Wait 8 seconds then enable a script to fade out Release text

    //    yield return new WaitForSecondsRealtime(8);
    //    release.GetComponent<UIFader>().enabled = true;
    //}

    //IEnumerator Fader()
    //{
    //    //wait 80 seconds then decrease music volume and turn on game fader
    //    Debug.Log("before time");
    //    yield return new WaitForSecondsRealtime(80);
    //    Debug.Log("after time");

    //    //turn down music volume slowly to match the speed the game fades out
    //    musicTime -= Time.deltaTime / 8;
    //    fader.SetActive(true);
    //    music.volume = musicTime;

    //    //wait for everything to fade out then quit the application
    //    yield return new WaitForSecondsRealtime(15);
    //    Application.Quit();
    //}

    

    //private void FaderPls()
    //{
    //    d += Time.deltaTime;

    //    if (d >= 80)
    //    {
    //        musicTime -= Time.deltaTime / 8;
    //        fader.SetActive(true);
    //        music.volume = musicTime;

    //        e += Time.deltaTime;
    //        if(e >= 15)
    //        {
    //            Application.Quit();
    //        }
    
    //    }
    //}
}
