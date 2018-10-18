using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_R : MonoBehaviour {

    public GameObject rockPrefab;

    public float interval;
    public float rock_position;

   

	// Use this for initialization
    IEnumerator Start () {
        while (true)
        {
            rock_position = rock_position + 30;   
            transform.position = new Vector3(rock_position, transform.position.y, transform.position.z);
            Instantiate(rockPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);


        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
