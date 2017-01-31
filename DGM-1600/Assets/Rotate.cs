using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    public float speed = 1.0f;

    void Start () {
        speed = Random.Range (.5f, 2.0f);
    }
        void Update (){ 
            transform.Rotate(new Vector3(15,30,45) * Time.deltaTime * speed);
        }

}