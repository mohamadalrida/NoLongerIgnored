using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move4 : MonoBehaviour {

	public Transform[] positions;
    public Canvas ChooserText;

	//public enum PositionsAt { one, two, three} ;
	//PositionsAt positionsAt;

	//bool calledMove;

    public float degreesPerSecond = 360.0f;



    // Use this for initialization
    void Start () {

        Destroy(ChooserText);
        
		
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(WaitToFloat());

        //iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(-600, 1500, 2000), "islocal", true, "time", 450.0f, "easetype", "easeInOutSine"));
        //transform.Rotate(Vector3.up * Time.deltaTime *2.5f); 
        
    }

    IEnumerator WaitToFloat()
    {
        yield return new WaitForSecondsRealtime(90);

        iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(-600, 1500, 2000), "islocal", true, "time", 450.0f, "easetype", "easeInOutSine"));
        transform.Rotate(Vector3.up * Time.deltaTime * 2.5f);
    }
}
