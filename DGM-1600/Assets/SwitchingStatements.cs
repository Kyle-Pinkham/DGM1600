using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingStatements : MonoBehaviour {

    public int cardNumber = 5;


    void start()
    {
        switch (cardNumber)
        {
            case 5:
                print("work damn you");
                break;

        }
    } 
}

