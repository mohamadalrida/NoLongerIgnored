using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class DestroyOther : MonoBehaviour {

    //Used to track progression of gaze meter on lantern
    

    public float MyTime = 0f;
    public Transform MeterProgress;
    public GameObject lantern;
    public GameObject raycast;
    public GameObject reticle;
    public GameObject lantern1;
    public GameObject lantern2;
    public GameObject lamplight;
    public GameObject subtlelight;
    public GameObject canvas;
    public GameObject release;
    public CanvasGroup main;
    public CanvasGroup second;
    private float mainalpha;
    private float secondalpha;
    
    private bool raycaster;



	// Use this for initialization
	void Start () {

        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
        reticle.SetActive(false);
        //mainalpha =  canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;
        
        
	}
	
	// Update is called once per frame
	public void Update ()
    {
        //activate the meter 
        reticle.SetActive(true);

        //Counts up and fills meter along the way
        MyTime += Time.deltaTime;
        MeterProgress.GetComponent<Image>().fillAmount = MyTime/3;

        //Turns on a "hover over" light
        lamplight.GetComponent<Light>().enabled = true;

        if (MyTime >= 3f)
        {
            //Activate animation on lantern and disable raycasting script
            lantern.GetComponent<move1>().enabled = true;
            raycast.GetComponent<VREyeRaycaster>().enabled = false;
            
            //Call these three functions
            ResetTime();
            SetLight();
            CanvasSet();

            //Destroy reticle and other lantern, then destroys this script to avoid 
            //further counting 
            Destroy(reticle);
            Destroy(lantern1);
            Destroy(lantern2);
            Destroy(gameObject.GetComponent<DestroyOther>());
        }
	}

    public void ResetTime()
    {
        //Resets time and metre progress 
        MyTime = 0f;
        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
        reticle.SetActive(false);

        //turns off extra lights to avoid too much instensity
        lamplight.GetComponent<Light>().enabled = false;
        lamplight.GetComponent<LightIncrease>().enabled = false;
    }

    public void SetLight()
    {
        //turn on the base light 
        lamplight.GetComponent<Light>().enabled = true;
    }

    public void CanvasSet()
    {
        //fades out "choose" text and enables the Release script
        canvas.GetComponent<UIFader>().enabled = true;
        gameObject.GetComponent<Releaser>().enabled = true;
    }

    
}
