using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveStage : MonoBehaviour {

    public string stageName;

	// Use this for initialization
    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Submit"))
        {
            Application.LoadLevel(stageName);
        }
	}
}
