using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : MonoBehaviour {
    int animal_state = 0;
    public float speed = 20f;
    public float jumpPower = 30f;

    CharacterController characterController;
    Rigidbody rb;

    // Use this for initialization
    void Start () {
        Invoke("ChangeAnimalState", 0.3f);
    }
	
	// Update is called once per frame
	void Update () {
/*
        transform.Translate(0, 0, speed * Time.deltaTime);
        //transform.Translate(speed * Time.deltaTime, 0, 0);
        Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);
        }
        
        
        */
		if(animal_state==1)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        }
	}
    
    void OnTriggerEnter(Collider other)
    {
        Invoke("ChangeAnimalState", 0.5f);
    }

    void ChangeAnimalState()
    {
        animal_state = 1;
    }
    
}
