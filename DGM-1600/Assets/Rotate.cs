using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    public float speed = 1.0f;
	public float rotX = 15;
	public float rotY = 30;
	public float rotZ = 45;


    void Start () {
        speed = Random.Range (.5f, 2.0f);
    }
        void Update (){ 
            transform.Rotate(new Vector3(rotX,rotY,rotZ) * Time.deltaTime * speed);
        }

}