using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOther : MonoBehaviour {

    public float MyTime = 0f;
    public Transform MeterProgress;
    public GameObject lantern;



	// Use this for initialization
	void Start () {

        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
        
	}
	
	// Update is called once per frame
	public void Update ()
    {
        MyTime += Time.deltaTime;

        MeterProgress.GetComponent<Image>().fillAmount = MyTime/2;

        if (MyTime >= 2f)
        {
            lantern.GetComponent<move1>().enabled = true;
        }
	}

    public void ResetTime()
    {
        MyTime = 0f;
        MeterProgress.GetComponent<Image>().fillAmount = MyTime;
    }
}
