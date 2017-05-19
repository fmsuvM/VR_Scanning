using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityOSC;

public class OSCCamera : MonoBehaviour {
	#region Network Settings
	public string TargetAddr;
	public int OutGoingPort;
	public int InComingPort;
	#endregion
	private Dictionary<string, ServerLog> servers;

	public TextMesh valueText; 
	public GameObject mainCamera;
	// Script initialization
	void Start() {  
		OSCHandler.Instance.Init();
		servers = new Dictionary<string, ServerLog>();

		valueText = GetComponent<TextMesh> ();
		mainCamera = GameObject.FindWithTag("MainCamera");
	}

	// NOTE: The received messages at each server are updated here
	// Hence, this update depends on your application architecture
	// How many frames per second or Update() calls per frame?
	void Update() {
		// must be called before you try to read value from osc server
		OSCHandler.Instance.UpdateLogs();

		// データ受信部
		servers = OSCHandler.Instance.Servers;
		foreach( KeyValuePair<string, ServerLog> item in servers )
		{
			// If we have received at least one packet,
			// show the last received from the log in the Debug console
			if(item.Value.log.Count > 0) 
			{
				int lastPacketIndex = item.Value.packets.Count - 1;

//				UnityEngine.Debug.Log(String.Format("SERVER: {0} ADDRESS: {1} VALUE 0: {2}", 
//					item.Key, // Server name
//					item.Value.packets[lastPacketIndex].Address, // OSC address
//					item.Value.packets[lastPacketIndex].Data[0].ToString())); //First data value

				String[] cameraPos = item.Value.packets[lastPacketIndex].Data[0].ToString().Split(',');
				float x = float.Parse (cameraPos[0], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				float y = float.Parse (cameraPos[1], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				float z = float.Parse (cameraPos[2], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				float rx = float.Parse (cameraPos[3], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				float ry = float.Parse (cameraPos[4], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				float rz = float.Parse (cameraPos[5], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				//float rw = float.Parse (cameraPos[6], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
				//Debug.Log (rx);
				mainCamera.transform.position = new Vector3(x, y, z);
				//mainCamera.transform.rotation = new Quaternion(rx, ry, rz, rw);
				mainCamera.transform.localEulerAngles = new Vector3(rx, ry, rz);
			}
		} 
	}
}