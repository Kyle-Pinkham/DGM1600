using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishStampArray : MonoBehaviour {

    string[] fishes = new string[5] { "Octopus", "Swordfish", "Carp", "Jellyfish", "Shark" };
    string[] letters = new string[5] { "A", "B", "C", "D", "E" };
    string[] birds = new string[5] { "Robin", "Raven", "Parrot", "Puffin", "Penguin" };
    public static Vector3 mousePosition;
    int i = 0;

    void Start () {

        while(i < 5)
        {
            print(fishes[i] + " " + letters[i] + " " + birds[i] + ".");
            i++;

            if (i >= 100)
                break;

        }
       
	}
	
	// Update is called once per frame
	void Update () {
        {
            if (Input.GetMouseButtonDown(0))
                Debug.Log("Pressed left click.");
        }
    }
}
