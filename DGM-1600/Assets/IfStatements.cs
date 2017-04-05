using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IfStatements : MonoBehaviour {

    int A = 10;
    int B = 20;
    bool death = true;
    string destiny = "Destiny";
    string doom = "Doom";


    /*
        Testing:    Strings,  Bools, 
        ==  
        !=
        <
        >
        <=
        >=
    */

    void Start() {

        if (death) {
            print(destiny);
        }
        if (!death) {
            print(doom);
        }
        if (A != B)
        {
            print("DISCOTIMEEEEEEEE");
            print("Full disclosure I just want this assignment done");
        }
        //      this is extremely poor code. you shouldn't need to declare an if statment when it's already been called in the method.
        //      This is for explaination purposes only.
        if (death)
        {
            print("Why make both lines of code on a single statment when you make make two if statements that are called on the exact same variable!!?");
        }

        //      -------- Class Examples --------
        //      if (A == B)
        //          print("A is exactly the same as B");
        //      if (A != B)
        //          print("A is not equal to B, loser");
        //      if (A < B)
        //          print("B is the biggest one");
        //      if (A > B)
        //          print("A IS BIGGER THEN B, GET OVER IT");
        //      if (A <= B)
        //          print("A is smaller then B, or equal too it");
        //      if (A >= B)
        //          print("A is at least bigger then B");

    }


    void Update() {
        // This code kills the supadisco script
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
           death = false;
        }
        // This code makes a supadisco script which will change the color  24 times/second (due to the 24 frames a second its shot at)
        if (death == true) {

            if (GetComponent<Renderer>().material.color == Color.green)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
           else if (GetComponent<Renderer>().material.color == Color.red)
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (GetComponent<Renderer>().material.color == Color.blue)
            {
                GetComponent<Renderer>().material.color = Color.black;
            }
            else if (GetComponent<Renderer>().material.color == Color.black)
            {
                GetComponent<Renderer>().material.color = Color.white;
            }
            else if (GetComponent<Renderer>().material.color == Color.white)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }




        }

    }
}
