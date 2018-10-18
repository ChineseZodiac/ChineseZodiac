using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
    int animal_state = 0;
    public float speed = 20f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
