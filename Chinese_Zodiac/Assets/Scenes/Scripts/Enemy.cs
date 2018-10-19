using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {

    public float speed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,0,speed * Time.deltaTime);
        Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);
    }
}
