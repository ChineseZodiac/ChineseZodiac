using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
        // Player 반대편에서 달려옴
        transform.Translate(0,0,speed * Time.deltaTime);
    }
}
