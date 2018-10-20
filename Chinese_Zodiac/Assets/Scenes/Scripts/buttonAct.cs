using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAct : MonoBehaviour {
    public string SceneName;

    public void OnClickExit()
    {
        Application.LoadLevel(SceneName);
    }
}
