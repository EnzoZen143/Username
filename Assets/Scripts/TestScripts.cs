using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNameSpace;

public class TestScripts : MonoBehaviour
{
    private SimpleScripts simpleScripts;

    private void Start()
    {
        simpleScripts = GetComponent<SimpleScripts>();
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Press me nigga"))
        { 
            string newUserName = simpleScripts.UserName;
            Debug.Log(newUserName);
        }
    }
}
