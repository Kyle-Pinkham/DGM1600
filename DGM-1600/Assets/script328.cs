using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script328 : MonoBehaviour {


    void MyFunction(float y, float x, float z) {

       print(y * z * x);

    }

    void MyArrayFunction() {
        string[] colors = new string[5] { "red", "blue", "green", "purple", "orange" };
        string[] names = new string[5] { "Joann", "Bobby", "Josh", "Henry", "STORMAGEDDON, DARK LORD OF ALL" };

        for (int i=0; i <names.Length; i++) {

            print(names[i] +  "'s favorite color is " + colors[i]);

        }
    }

}
