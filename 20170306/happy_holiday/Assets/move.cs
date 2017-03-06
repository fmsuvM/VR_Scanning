using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    GameObject mainCamera;
    Vector3 s = new Vector3(-20, 7, 2.2f);
    Vector3 e = new Vector3(170, 7, 2.2f);

    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }
    // Update is called once per frame
    void Update()
    {
        //mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, mainCamera.transform.position.z - 10);
        if (mainCamera.transform.position.x < 170)
        {
            mainCamera.transform.position += new Vector3(0.1f, 0, 0);
        }else
        {
            mainCamera.transform.position = s;
        }
        /*Vector3 pos = mainCamera.transform.position;
        pos.x += 0.5f;
        mainCamera.transform.position = pos;*/

    }
}
