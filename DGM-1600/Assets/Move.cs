using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
		public float horizontalSpeed = .2f;
			
		public float verticalSpeed = .2f ;
		
		//update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftShift)); {
			 horizontalSpeed = .5f;
			
				if(Input.GetKey(KeyCode.LeftArrow)) {
			gameObject.transform.Translate(-horizontalSpeed, 0, 0);
			}
			if (Input.GetKey(KeyCode.RightArrow)) {
            gameObject.transform.Translate(horizontalSpeed, 0, 0);
			}
			if (Input.GetKey(KeyCode.UpArrow))
			{
			gameObject.transform.Translate(0, verticalSpeed, 0);
			}
			if (Input.GetKey(KeyCode.DownArrow)){
                gameObject.transform.Translate(0, verticalSpeed, 0);
            }
		}
    }	
}