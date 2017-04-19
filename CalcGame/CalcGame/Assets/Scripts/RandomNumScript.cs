using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumScript : MonoBehaviour {

    public float delay = 2.5f;
    public GameObject Circle;
    public GUIContent Canvas;
    public float minVal = 0;
    public float maxVal = 100;

    
    private float randVal;
    private int counter = 0;


    void Start() {
        InvokeRepeating("Spawn", delay, delay);

    }

    void Update() {

    }

    void NumRandomizer() {
        while (true) {
            randVal = Random.Range(minVal, maxVal);
            Debug.Log(randVal);
            counter++;


            if (counter >= 100)
                break;

        }

    }
    void Spawn() {
        Instantiate(Circle, new Vector2(Random.Range(-7, 7), 10), Quaternion.identity);
        

    }
}
