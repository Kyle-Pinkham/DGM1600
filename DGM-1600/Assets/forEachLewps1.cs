using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forEachLewps1 : MonoBehaviour {

    public List<string> aminols;
    public List<string> cats;
    public List<string> dogs;

    // Use this for initialization
    void Start() {

        foreach (string animal in aminols) {

            print(animal);
            switch (animal) {

                case "cat":
                    cats.Add(animal);
                    break;
                case "dog":
                    dogs.Add(animal);
                    break;

                default:
                    break;
            }
        }

    }
}