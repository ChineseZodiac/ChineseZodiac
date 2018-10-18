using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour {

    public float speed = 10f;
    public float jumpPower = 5f;


    CharacterController characterController;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
		
	}


	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);


       if(Input.GetKeyDown(KeyCode.UpArrow))
        { 
            rb.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);
        }

        /*
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }*/


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Obstacle")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
