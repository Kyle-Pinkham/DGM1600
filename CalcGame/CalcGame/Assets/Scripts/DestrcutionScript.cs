using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrcutionScript : MonoBehaviour {

    public GameObject Circle;

    void start() {
    }

    void OnTriggerEnter2D() {
        var audioFile = Circle.GetComponentInChildren<AudioSource>();

        Debug.Log(gameObject);
        audioFile.Play();
        Object.Destroy(gameObject);

        Debug.Log("death");
    }
}
