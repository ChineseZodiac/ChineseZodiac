using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public float speed;
    public float jumpPower;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // Player와 같은 속도로 이동
        transform.Translate(speed * Time.deltaTime, 0, 0);	
	}
}
