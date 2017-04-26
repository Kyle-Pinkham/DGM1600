﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalcSkript : MonoBehaviour {

    public Button addButton;
    public Button subButton;
    public Button divButton;
    public Button mulButton;

    public float Num1;
    public float Num2;
    public float Result = 0;
    public InputField InNum1;
    public InputField InNum2;
    public Text resultNum;
    private bool buttonActiveChecker = true;


    void Start() {
    }

    void Update() {
        resultNum.text = "" + Result.ToString();
    }

    public static bool NumberChecker(float x) {
        bool result = false;
        var circleList = GameObject.FindGameObjectsWithTag("Number");

        foreach (GameObject circle in circleList) {
           var circleMesh = circle.GetComponent<TextMesh>();
            var audioFile = circle.GetComponent<AudioSource>();
                if (circleMesh != null){
                audioFile.Play();
                        if (x == float.Parse(circleMesh.text)) {
                            Destroy(circle.transform.parent.gameObject);
                            result = true;
                        }
                }

        }
        return result;   
    }

    public void ButtonInactive(Button butt) {

        if (NumberChecker(Result)) {
            butt.interactable = false;
            if (addButton.interactable == false &&
                subButton.interactable == false &&
                divButton.interactable == false &&
                mulButton.interactable == false)
               {addButton.interactable = true;
                subButton.interactable = true;
                divButton.interactable = true;
                mulButton.interactable = true;}
        }
    }

    public void ButtonAdd() {
        Result = (float.Parse(InNum1.text) + float.Parse(InNum2.text));
        ButtonInactive(addButton);
    }

    public void ButtonSub() {
        Result = (float.Parse(InNum1.text) - float.Parse(InNum2.text));
        ButtonInactive(subButton);

    }

    public void ButtonDiv() {
        Result = (float.Parse(InNum1.text) / float.Parse(InNum2.text));
        ButtonInactive(divButton);

    }

    public void ButtonMul() {
        Result = (float.Parse(InNum1.text) * float.Parse(InNum2.text));
        ButtonInactive(mulButton);

    }


}
