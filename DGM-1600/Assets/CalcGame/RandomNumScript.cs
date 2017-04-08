using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumScript : MonoBehaviour {

    public float delay = 0.1f;
    public GameObject Circle;

    private float minVal = 0;
    private float maxVal = 100;
    private float randVal;
    private int counter = 0;

    void Start() {
        InvokeRepeating("Spawn", delay, delay);
    }
    void NumRandomizer() {
        while (true) {
            randVal = Random.Range(minVal, maxVal);
            counter++;


            if (counter >= 100)
            break;

        }

    }
    void Spawn() {
        Instantiate(Circle, new Vector3(0, 0, 90), Quaternion.identity);
    }


}
