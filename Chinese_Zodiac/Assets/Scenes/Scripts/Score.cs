using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static Score instance;   // 자기 자신을 저장할 변수
    public Text scoreText;
    public static float score;

    void Awake()
    {
        if (!instance)  // 정적으로 자신 체크
            instance = this;    // 정적으로 자신 저장
    }

    public void AddScore(int num)
    {
        score += num;
    }

    public void SubScore(int num)
    {
        score -= num;
    }

    public void Reset()
    {
        score = 1000;
    }
	// Use this for initialization
	void Start () {
        score = 100;
	}
	
	// Update is called once per frame
	void Update () {
        score -= Time.deltaTime*5;
        scoreText.text = ((int)score).ToString();

        if(score<0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
	}
}
