using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    GameObject mainCamera;

    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }
    // Update is called once per frame
    void Update()
    {
        //mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, mainCamera.transform.position.z - 10);
        mainCamera.transform.position += new Vector3(0.1f , 0, 0);
        /*Vector3 pos = mainCamera.transform.position;
        pos.x += 0.5f;
        mainCamera.transform.position = pos;*/

    }
}
