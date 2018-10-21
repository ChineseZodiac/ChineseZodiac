using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : MonoBehaviour {
    public float speed = 20f;
    public float delayTime;
    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        // Player와 같은 속도로 이동
        transform.Translate(0, 0, speed * Time.deltaTime);

        // UP 버튼 클릭 시 delayTime 후 점프
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Invoke("Jump", delayTime);
        }
        
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0, 1, 0) * 30f, ForceMode.Impulse);
    }
}
