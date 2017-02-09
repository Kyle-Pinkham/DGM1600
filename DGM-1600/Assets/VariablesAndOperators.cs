using UnityEngine;
using System.Collections;

public class VariablesAndOperators : MonoBehaviour {

    private float pi = 3.1415f;
    private float radius = 2.5f;
    private float l = 2f;
    private float w = 3f;
    private float tBase = 4f;
    private float tHeight = 5f;

        void Start () {
        // Circle Section:
            float diameter = 2 * radius;
            print("The Diamater of the circle with a radius of " + radius + " is " + diameter);
            float circumference = 2 * pi * radius;
            print("The Circumference of the circle with a radius of " + radius + " is " + circumference);
            float areaCi = pi * (radius * radius) ;
        // Math.pow() can also be used here, but creates a complex method for a value we know is simply r^2
            print("The Area of a circle happens to be " + areaCi);
            float volumeCi = (4.0f / 3f) * pi * (radius * radius * radius);
            print("The Volume of a sphere happens to be " + volumeCi);
        // Square Section:
            float areaSq = l * w;
            print("The area of a Squayure is " + areaSq + " inches ");
        // I feel like there is probably a fancier way to do this but... if I get to arbitrarily assign the values this is far simpler..
            float perimSq = 2 * (l + w);
            print("The peri-meter of a Squayure is " + perimSq + " inches ");
        // Triangle Section
            float tArea = (tBase * tHeight) * 0.5f;
            print("The area of a 'Try'angle is " + tArea + " inches ");
        // 0.5 is just for funnzies. Technichally, (tBase * tHeight) / 2  would probably be a bit better. BUT WHO CARES I AM DEMONSTRATING MY UNDERSTANDING.
    }
}
