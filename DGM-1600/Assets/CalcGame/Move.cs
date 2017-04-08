using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	    public float speed1 = .5f;
 //       public float speed2 = 1f;

    private float xAxisSpd()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) return -speed1;
        if (Input.GetKey(KeyCode.RightArrow)) return speed1;
        return 0;
    }

    private float yAxisSpd()
    {
        if (Input.GetKey(KeyCode.DownArrow)) return -speed1;
        if (Input.GetKey(KeyCode.UpArrow)) return speed1;
        return 0;
    }

    void Update ()
    {     
        gameObject.transform.Translate(xAxisSpd(), yAxisSpd(), 0);
    }
}

// This is the code from the class that I've copied.

//      if (Input.GetKey(KeyCode.LeftArrow)) {
//          if (Input.GetKey(KeyCode.LeftShift)) {
//          gameObject.transform.Translate(-speed2, 0, 0);
//          }
//          else {
//          gameObject.transform.Translate(-speed1, 0, 0);
//          }
//}
//      if (Input.GetKey(KeyCode.RightArrow)) {
//          gameObject.transform.Translate(speed1, 0, 0);
//      }
//      if (Input.GetKey(KeyCode.UpArrow))
//      {
//          gameObject.transform.Translate(0, speed1, 0);
//      }
//      if (Input.GetKey(KeyCode.DownArrow)){
//              gameObject.transform.Translate(0, -speed1, 0);
//          }
