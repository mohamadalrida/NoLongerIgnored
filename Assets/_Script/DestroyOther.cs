using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class DestroyOther : MonoBehaviour {

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
    public float mainalpha;
    public float secondalpha;


    private bool raycaster;



	// Use this for initialization
	void Start () {

        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
        reticle.SetActive(false);
        canvas.GetComponent<CanvasGroup>().alpha = mainalpha;
        release.GetComponent<CanvasGroup>().alpha = secondalpha;
        
        
	}
	
	// Update is called once per frame
	public void Update ()
    {
        MyTime += Time.deltaTime;

        MeterProgress.GetComponent<Image>().fillAmount = MyTime/3;

        reticle.SetActive(true);

        lamplight.GetComponent<Light>().enabled = true;
        

        if (MyTime >= 3f)
        {

            lantern.GetComponent<move1>().enabled = true;
            raycast.GetComponent<VREyeRaycaster>().enabled = false;
            

            ResetTime();
            SetLight();
            CanvasSet();
            

            Destroy(reticle);
            Destroy(lantern1);
            Destroy(lantern2);
            Destroy(gameObject);
        }
	}

    public void ResetTime()
    {
        MyTime = 0f;
        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
        reticle.SetActive(false);
        lamplight.GetComponent<Light>().enabled = false;
        lamplight.GetComponent<LightIncrease>().enabled = false;
    }

    public void SetLight()
    {
        lamplight.GetComponent<Light>().enabled = true;
    }

    public void CanvasSet()
    {

        canvas.GetComponent<UIFader>().enabled = true;

        //if (mainalpha == 0f)
        //{
        //    release.SetActive(true);
        //    StartCoroutine(Releaser());

        //}


    }

    //IEnumerator Releaser()
    //{
    //    yield return new WaitForSeconds(2);
    //    Debug.Log("hello");
    //    //release.GetComponent<UIFader>().enabled = true;
    //    Destroy(release, 3);
    //}
}
