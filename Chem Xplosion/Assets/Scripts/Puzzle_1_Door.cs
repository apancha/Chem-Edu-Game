using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1_Door : MonoBehaviour {

	private Animator dAnimate;
	public static int puzzleOneCount;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

//	void OnTriggerEnter(Collider col){
//		if (col.tag == "Player") {
			
//		}
//	}

	// Update is called once per frame
	void Update () {
		puzzleOneCount = Onhit.counter;

		if (puzzleOneCount == 2){
		dAnimate.SetBool ("open", true);
	}
}
}
