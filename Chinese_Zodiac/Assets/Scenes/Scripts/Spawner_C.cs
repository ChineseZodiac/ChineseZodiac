using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_C : MonoBehaviour {

    public GameObject cactusPrefab;
    public float interval;
    public float position;

    // Use this for initialization
    IEnumerator Start () {
        while (true)
        {
            position = position + 50;
            transform.position = new Vector3(position, transform.position.y, transform.position.z);
            Instantiate(cactusPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
