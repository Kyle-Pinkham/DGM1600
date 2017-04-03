using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalcSkript : MonoBehaviour {

    public float Num1;
    public float Num2;
    public float Result = 0;
    public Text InNum1;
    public Text InNum2;
    public Text resultNum;


    void Start() {
        resultNum = GameObject.Find("resultNum").GetComponent<Text>();
        InNum1 = GameObject.Find("InNum1").GetComponent<Text>();
        InNum2 = GameObject.Find("InNum2").GetComponent<Text>();
    }

    void FixedUpdate() {
        resultNum.text = "" + Result.ToString();
        InNum1.text = "" + Num1.ToString();
        InNum2.text = "" + Num2.ToString();

    }

    public void ButtonAdd() {
        print(Num1 + Num2);
        Result = Num1 + Num2;

    }

    public void ButtonSub() {
        print(Num1 - Num2);
        Result = Num1 + Num2;
    }

    public void ButtonDiv() {
        print(Num1 / Num2);
        Result = Num1 / Num2;
    }

    public void ButtonMul() {
        print(Num1 * Num2); 
        Result = Num1 * Num2;
    }

}
