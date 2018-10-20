using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAct : MonoBehaviour {

    public void OnClickExit()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
