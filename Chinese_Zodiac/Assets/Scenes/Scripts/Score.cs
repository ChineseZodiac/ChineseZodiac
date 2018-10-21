using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static Score instance;   // 자기 자신을 저장할 변수
    public Text scoreText;  // 점수 Text
    public static float score;  // 점수 저장할 변수

    void Awake()
    {
        if (!instance)  // 정적으로 자신 체크
            instance = this;    // 정적으로 자신 저장
    }

    // 음식 만나면 점수 증가
    public void AddScore(int num)
    {
        score += num;
    }

    // 장애물 만나면 점수 감소
    public void SubScore(int num)
    {
        score -= num;
    }

	// Use this for initialization
	void Start () {
        score = 100;    // 처음에 점수 100으로 시작
	}
	
	// Update is called once per frame
	void Update () {
        // 시간에 따라 점수 지속적으로 감소
        score -= Time.deltaTime*5;
        // 텍스트 갱신
        scoreText.text = ((int)score).ToString();
        
	}
}
