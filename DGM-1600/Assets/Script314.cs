using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Script314 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void CurrentTime() {
        string greeting;
        int hour = DateTime.Now.Hour;
        if (hour < 12) greeting = "good morning";
        else if (hour < 17) greeting = "good afternoon";
        else greeting = "Good evening";

        print(greeting + ", the current time is " + hour + ".");

        string.Format("{0}, the current time is {1}.", greeting, DateTime.Now.ToLongTimeString());
    }
    
    public void CurrentDate() {
        string date;
        print(string.Format("The date is {0}.", DateTime.Now.ToLongDateString()));
        
        
    }
}
