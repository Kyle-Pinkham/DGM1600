﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalcSkript : MonoBehaviour {

    public float Num1;
    public float Num2;
    public float Result = 0;
    public InputField InNum1;
    public InputField InNum2;
    public Text resultNum;


    void Start() {

    }

    void Update() {
        NumberChecker(Result);
        resultNum.text = "" + Result.ToString();
    }

    public static void NumberChecker(float x) {
        var circleList = GameObject.FindGameObjectsWithTag("Number");
        foreach (GameObject circle in circleList) {
            var circleMesh = circle.GetComponent<TextMesh>();
            if (circleMesh != null){
                if (x == float.Parse(circleMesh.text)) {
                    Destroy(circle.transform.parent.gameObject);

                }
            }

        }
        
    }

    public void ButtonAdd() {
        Result = (float.Parse(InNum1.text) + float.Parse(InNum2.text));
    }

    public void ButtonSub() {
        Result = (float.Parse(InNum1.text) - float.Parse(InNum2.text));
    }

    public void ButtonDiv() {
        Result = (float.Parse(InNum1.text) / float.Parse(InNum2.text));
    }

    public void ButtonMul() {
        Result = (float.Parse(InNum1.text) * float.Parse(InNum2.text));
    }


}
