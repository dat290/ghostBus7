using UnityEngine;
using System.Collections;
using System.IO;
using System.Xml;
using System.Net;

public class WebCall : MonoBehaviour {
	public string url = "http://bustime.mta.info/api/siri/vehicle-monitoring.xml?key=9030507a-62c2-4168-825d-ddf477ec1b22&OperatorRef=MTA+NYCT&LineRef=B54&VehicleRef=7279";
	string filePath;
	string xmlContent;
	public string longitude;
	public string latitude;
	public static float lon;
	public static float lat;
	// Use this for initialization
	void Start () {
	//	StartCoroutine (callWeb ());
		filePath = Application.dataPath + "/BusData.xml";
		WebClient Client = new WebClient ();
		Client.DownloadFile(url, filePath);
		Debug.Log ("This is executed");
		ReadXML ();
	}

//	IEnumerator callWeb()
//	{
//		WWW www = new WWW (url);
//		yield return www;
//	}
	
	// Update is called once per frame
	void Update () {
	}
//	void SaveToLocalPath(string content)
//	{
//		filePath = Application.dataPath + "/BusData.xml";
//		System.IO.File.WriteAllText (filePath, content);
//		Debug.Log (filePath);
//		Debug.Log (content);
//	}
	public void ReadXML()
	{
		XmlDocument doc = new XmlDocument();
		doc.Load(filePath);
		XmlNodeList longList = doc.GetElementsByTagName("Longitude");
		for (int i=0; i < longList.Count; i++)
		{   
			longitude = longList[i].InnerXml;
			Debug.Log(longList[i].InnerXml);
		}
		XmlNodeList latList = doc.GetElementsByTagName("Latitude");
		for (int i=0; i < latList.Count; i++)
		{   
			latitude = latList[i].InnerXml;
			Debug.Log(latList[i].InnerXml);
		}
		lon = float.Parse (longitude);
		lat = float.Parse (latitude);

	}

	
}
