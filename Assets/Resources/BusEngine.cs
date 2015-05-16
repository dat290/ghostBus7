using UnityEngine;
using System.Collections;

public class BusEngine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 0.01f;
	}
}
