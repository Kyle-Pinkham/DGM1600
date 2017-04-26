using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrcutionScript : MonoBehaviour {

    private GameObject Circle;


    void Awake() {
    }

    void OnTriggerEnter2D() {
        Debug.Log(gameObject);

        Object.Destroy(gameObject);

        Debug.Log("death");
    }
}
