using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Releaser : MonoBehaviour {

    public GameObject canvas;
    public GameObject release;
    public CanvasGroup main;
    public CanvasGroup second;
    public float mainalpha;
    public float secondalpha;

	// Use this for initialization
	void Start () {

        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;
    }
	
	// Update is called once per frame
	void Update () {

        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;

        if (mainalpha == 0f)
        {
            release.SetActive(true);
            

            if (secondalpha == 1f)
            {
                StartCoroutine(Releasing());
            }
        }
	}

    IEnumerator Releasing()
    {
        Debug.Log("hey");
        yield return new WaitForSeconds(2);
        release.GetComponent<UIFader>().enabled = true;
    }
}
