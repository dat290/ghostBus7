using UnityEngine;
using System.Collections;
using iGUI;

public class iGUICode_MapNav_3D_Demo : MonoBehaviour{
	[HideInInspector]
	public iGUIRoot root1;

	static iGUICode_MapNav_3D_Demo instance;
	void Awake(){
		instance=this;
	}
	public static iGUICode_MapNav_3D_Demo getInstance(){
		return instance;
	}

}
