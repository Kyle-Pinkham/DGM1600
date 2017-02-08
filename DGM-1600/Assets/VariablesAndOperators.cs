using UnityEngine;
using System.Collections;

public class VariablesAndOperators : MonoBehaviour {

    private float pi = 3.1415f;
    private float radius = 2.5f;
    private float l = 2;
    private float w = 2;


        void Start () {
            float diameter = 2 * radius;
          print("The Diamater of the circle with a radius of " + radius + " is " + diameter);
            float circumference = 2 * pi * radius;
          print("The Circumference of the circle with a radius of " + radius + " is " + circumference);
            float areaCi = pi * radius ;
          print("The Area of a circle happens to be " + areaCi);
            float areaSq = l * w;
          print("The area of a Squayure is " + areaSq + " inches ");
    }
}
