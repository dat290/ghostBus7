using UnityEngine;
using System.Collections;
public class UpdateBusLocation : MonoBehaviour {
	private float height = 154;
	public MapNav gps;
	private bool gpsFix;
	private float initX;
	private float initZ;
	private float fixLatitude;
	private float fixLongitude;
 	public BusUpdater bupdater;
	public float orientation;
//	public float lati = 40.69355f;
//	public float longi = -73.97465f;
//	public float lati;
//	public float longi;
	private float scaleX = 1;
	private float scaleY = 1;
	private float scaleZ = 1;
	private Vector3 nextPos;
	Vector3 nextStop = new Vector3 (8.4f, 1.54f, -0.35f);
	public static float usLat;
	public static float usLon;
	//GameObject getScript = GameObject.FindGameObjectWithTag("busTest");
	//SetGeolocation getLocation = (SetGeolocation)getScript.GetComponent(typeof(SetGeolocation));
//	float nextStopLat = 40.69325f;
//	float nextStopLong = -73.97828f;
//	void Awake()
//	{
//		gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
//		gpsFix = gps.gpsFix;
//	}
	IEnumerator Start()
	{	//gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
		//Wait until the gps sensor provides a valid location.
		while (!gps.gpsFix)
		{
			gpsFix = gps.gpsFix;
			yield return null;
		}
		//Read initial position (used as a reference system)
		//bupdater.CallBuses ();
	}
	// Update is called once per frame
	//	void Update () {
	// transform.Translate (Vector3.forward * Time.deltaTime);
	//	transform.position = Vector3.MoveTowards (transform.position, nextStop, 1.0f * Time.deltaTime);
	//	transform.position = Vector3.MoveTowards (transform.position, nextPos, 1.0f * Time.deltaTime);

	//	Debug.Log (transform.position);
//	}
	public Vector3 getNewPosition(float busLat, float busLong)
	{	gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
		Debug.Log ("getNewPosition is executed");
		initX = gps.iniRef.x;
		initZ = gps.iniRef.z;
		//gpsFix = gps.gpsFix;
		if (gps.simGPS) {
			//fixLatitude = 42.3627f;
			//fixLongitude = -71.05686f;
			fixLatitude = gps.fixLat;
			fixLongitude = gps.fixLon;
		} else {
			fixLatitude = gps.userLat;
			fixLongitude = gps.userLon;
		//	fixLatitude = gps.fixLat;
		//	fixLongitude = gps.fixLon;
		//	gps.userLat = fixLatitude;
		//	gps.userLon = fixLongitude;
			Debug.Log (gps.userLat);
			Debug.Log(gps.userLon);
		}
		
	//	initX = fixLongitude * 20037508.34f / 18000;
	//	initZ = (float) (System.Math.Log(System.Math.Tan((90 + fixLatitude) * System.Math.PI / 360)) / (System.Math.PI / 180));
	//	initZ = initZ * 20037508.34f / 18000;

		//Translate the geographical coordinate system used by gps mobile devices(WGS84), into Unity's Vector2 Cartesian coordinates(x,z) and set height(1:100 scale).
		//transform.position = new Vector3(((lon * 20037508.34f) / 18000) - initX, height / 100, ((Mathf.Log(Mathf.Tan((90 + lat) * Mathf.PI / 360)) / (Mathf.PI / 180)) * 1113.19490777778f) - initZ);
		//nextPos = new Vector3(((busLong * 20037508.34f) / 18000) - initX, height / 100, ((Mathf.Log(Mathf.Tan((90 + busLat) * Mathf.PI / 360)) / (Mathf.PI / 180)) * 1113.19490777778f) - initZ);
		nextPos = new Vector3(((busLong * 20037508.34f) / 18000) - initX, height/100, ((Mathf.Log(Mathf.Tan((90 + busLat) * Mathf.PI / 360)) / (Mathf.PI / 180)) * 1113.19490777778f) - initZ);
		//		
		//		if(transform.localScale != Vector3.zero)
//			transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

		return nextPos;
		//Debug.Log ("NEXT POSITION: " + nextPos);

	}
//	private void UpdateLocation()
//	{ 
//		gps = GameObject.FindGameObjectWithTag("GameController").GetComponent<MapNav>();
//		gpsFix = gps.gpsFix;
//		fixLatitude = gps.fixLat;
//		fixLongitude = gps.fixLon;
//
//		initX = fixLongitude * 20037508.34f / 18000;
//		initZ = (float) (System.Math.Log(System.Math.Tan((90 + fixLatitude) * System.Math.PI / 360)) / (System.Math.PI / 180));
//		initZ = initZ * 20037508.34f / 18000;
//
//		//Translate the geographical coordinate system used by gps mobile devices(WGS84), into Unity's Vector2 Cartesian coordinates(x,z) and set height(1:100 scale).
//		//transform.position = new Vector3(((lon * 20037508.34f) / 18000) - initX, height / 100, ((Mathf.Log(Mathf.Tan((90 + lat) * Mathf.PI / 360)) / (Mathf.PI / 180)) * 1113.19490777778f) - initZ);
//		nextPos = new Vector3(((longi * 20037508.34f) / 18000) - initX, height / 100, ((Mathf.Log(Mathf.Tan((90 + lati) * Mathf.PI / 360)) / (Mathf.PI / 180)) * 1113.19490777778f) - initZ);
//		// Set Local Object Scale
//		if(transform.localScale != Vector3.zero)
//			transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
//		Debug.Log ("NEXT POSITION: " + nextPos);;
//
//
//	}

}
