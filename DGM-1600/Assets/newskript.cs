using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newskript : MonoBehaviour {

    private int A = 3;
    private int B = 8;
    private int C = -4;
    private int D = -2;


    // Use this for initialization
    void Start () {
        if (A == B || C < D)
        print("Hello World!");

        if ((B < C && D > C) || D == 0)
            print("Goodbye Cruel World");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
