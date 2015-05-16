using UnityEngine;
using System.Collections;

public class SetScene : MonoBehaviour {
	private MapNav gps;
	// Use this for initialization
	void Start () {
		gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
		gps.triDScene = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
