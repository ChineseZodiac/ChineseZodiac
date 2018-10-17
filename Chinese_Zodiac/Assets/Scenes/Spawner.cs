using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject Rock_prefab;
    public float interval;
    public float dist;
   

	// Use this for initialization
    IEnumerator Start () {
        while (true)
        {
            dist =+ 5;
            transform.position = new Vector3(dist,10, 0);
            Instantiate(Rock_prefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
            
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
