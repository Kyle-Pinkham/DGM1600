using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrcutionScript : MonoBehaviour {

    private GameObject Circle;

    void OnTriggerEnter2D() {
        Object.Destroy(gameObject);
        Debug.Log("death");
    }
}
