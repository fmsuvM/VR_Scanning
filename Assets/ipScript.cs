using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Sockets;//必要です。
using System.Net;//これもいるかもしれない

public class ipScript : MonoBehaviour {

	public GameObject messageText;

	public IPAddress myAddr;

	// Use this for initialization
	void Start () {
		myAddr = IPAddress.Parse (UnityEngine.Network.player.ipAddress);
		messageText = GameObject.Find("PIAdress");
	}
	
	// Update is called once per frame
	void Update () {
		messageText.GetComponent<TextMesh>().text = myAddr.ToString();
	}
}
