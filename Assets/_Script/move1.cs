using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour {

	public Transform[] positions;

	//public enum PositionsAt { one, two, three} ;
	//PositionsAt positionsAt;

	//bool calledMove;

    public float degreesPerSecond = 1.5f;



    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(-500, 500, 400), "islocal", true, "time", 180.0f, "easetype", "easeInOutSine"));
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        /*switch (positionsAt) {

		case PositionsAt.one:

			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [0].position, 60.0f);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [0].position) < 0.1) {
				positionsAt = PositionsAt.two;
				calledMove = false;
			}


			break;

		case PositionsAt.two:
			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [1].position, 20.0f);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [1].position) < 0.1) {
				positionsAt = PositionsAt.three;
				calledMove = false;

			}


			break;

		case PositionsAt.three:


			if (calledMove == false) {
				iTween.MoveTo (gameObject, positions [2].position, 20.0f);
				calledMove = true;
			}

			if (Vector3.Distance (transform.position, positions [2].position) < 0.1) {
				Debug.Log ("we have arrived");
			}


			break;


		}
        */
    }
}
