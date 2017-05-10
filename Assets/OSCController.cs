using UnityEngine;
using System.Collections;

public class OSCController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// this line triggers the magic
		OSCHandler.Instance.Init ();

		Debug.Log ("値送る");
		int testInteger = 54321;
		OSCHandler.Instance.SendMessageToClient ("myRemoteLocation", "192.168.2.100:12000", testInteger);

	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("値送るupdate");
		int testInteger = 54321;
		int random = Random.Range (0, 10000);
		OSCHandler.Instance.SendMessageToClient ("myRemoteLocation", "192.168.2.100:12000", random);

	}
}
