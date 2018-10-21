using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAct : MonoBehaviour {
    public string SceneName;

    // 버튼 클릭 이벤트
    public void OnClickExit()
    {
        // 다음 신으로 이동
        Application.LoadLevel(SceneName);
    }
}
