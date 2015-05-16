using UnityEngine;
using System.Collections;

public class SetScene2D : MonoBehaviour {
	private MapNav gps;
	// Use this for initialization
	void Start () {
		gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
		gps.triDScene = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
