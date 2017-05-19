using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class test : MonoBehaviour {
	//var device;

	// Use this for initialization
	void Start () {
		//device = SteamVR_Controller.Input(0);
		//Debug.Log(this.ToString2());
	}
	
	// Update is called once per frame
	void Update () {
		var device = SteamVR_Controller.Input(1);
		//transform.localPosition = InputTracking.GetLocalPosition(VRNode.LeftHand);
		//Debug.Log (InputTracking.GetLocalPosition(VRNode.RightHand));
		//Debug.Log ((InputTracking.GetLocalRotation(VRNode.RightHand).eulerAngles*Mathf.Deg2Rad).ToString("f8"));
		Debug.Log(device.transform.pos);
		Debug.Log((device.transform.rot).eulerAngles);
	}
}
