﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour {

    public float speed = 5f;
    public float jumpSpeed = 8.0f;
   


    CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();

		
	}
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);


    }
}
