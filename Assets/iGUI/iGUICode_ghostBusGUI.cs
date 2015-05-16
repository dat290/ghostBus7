using UnityEngine;
using System.Collections;
using iGUI;

public class iGUICode_ghostBusGUI : MonoBehaviour{
	[HideInInspector]
	public iGUIRoot root1;

	static iGUICode_ghostBusGUI instance;
	void Awake(){
		instance=this;
	}
	public static iGUICode_ghostBusGUI getInstance(){
		return instance;
	}

}
