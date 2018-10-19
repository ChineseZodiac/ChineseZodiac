using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour {

    public GameObject warning;
    public float speed = 10f;
    public float jumpPower = 5f;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        warning.SetActive(false);
	}


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        //Vector3 direction = new Vector3(0, Input.GetAxis("Horizontal"), 0);

        Vector3 pos;
        pos = this.transform.position;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            Score.instance.AddScore(1);
        
            Destroy(other.gameObject);
        }
        if (other.tag == "Obstacle")
        {
            warning.SetActive(true);
            Score.instance.SubScore(10);
            Invoke("Warning", 0.5f);
        }
        // 문을 만나면 스테이지 클리어
        if (other.tag == "Door")
        {
            Application.LoadLevel(Application.loadedLevel);
            Score.instance.Reset();
        }
    }
   void Warning()
    {
        warning.SetActive(false);
    }
}
