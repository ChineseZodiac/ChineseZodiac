using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_R : MonoBehaviour {

    public GameObject rockPrefab;

    public float interval;
    public float rock_position;


	// Use this for initialization
    IEnumerator Start() {
        int i = 0;
        int[] position = { 15, 55, 70, 90, 120, 140, 150, 160, 200, 250 };
        for (i = 0; i<10; i++)
        {
            rock_position = position[i];
            transform.position = new Vector3(rock_position, 0, transform.position.z);
            Instantiate(rockPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);


        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
