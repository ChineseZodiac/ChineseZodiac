using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string failScene;
    public string clearScene;
    public GameObject warning;  // Red Panel
    public float speed = 20f;
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
        transform.Translate(0, 0, speed * Time.deltaTime);

        // UP 버튼 누를 시 점프
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);
        }

        // 점수가 0이하가 되면 FailScene으로 이동
        if(Score.score <= 0 )
        {
            Application.LoadLevel(failScene);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 음식
        if (other.tag == "Apple")
        {
            // 음식을 만나면 점수 증가
            Score.instance.AddScore(1);
            // 먹은 음식은 사라짐
            Destroy(other.gameObject);
        }
        // 장애물
        if (other.tag == "Obstacle")
        {
            // Red Panel 0.5초간 띄우기
            warning.SetActive(true);
            Invoke("Warning", 0.5f);

            // 장애물 만나면 점수 감소
            Score.instance.SubScore(10);
        }
        // 문
        if (other.tag == "Door")
        {
            // 스테이지 클리어
            Application.LoadLevel(clearScene);
        }
        // 적
        if (other.tag == "Enemy")
        {
            // 적을 만나면 FailScene으로 이동
            Application.LoadLevel(failScene);
        }
    }

    // Red Panel 안보이기
   void Warning()
    {
        warning.SetActive(false);
    }
}
