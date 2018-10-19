using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_F : MonoBehaviour {

    public GameObject fencePrefab;
    public float interval;
    public float fence_position;


    // Use this for initialization
    IEnumerator Start () {
        while(true)
           
        {
                fence_position = fence_position + 50;
                transform.position = new Vector3(fence_position, transform.position.y, transform.position.z);
                Instantiate(fencePrefab, transform.position, transform.rotation);
                yield return new WaitForSeconds(interval);
        }

    

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
