using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatments : MonoBehaviour
{
    private float grade;
    bool death = true;

    // Use this for initialization
    void Start()
    {


        //This line of code creates a loop- as long as i <= 100, it will add i+1, with I starting at 1
        for (int i = 1; i <= 100; i++)
        {
            // in practice, any number divided by three will be true for fizz, and any divided by five will be true for buzz.
            bool fizz = i % 3 == 0;
            // For clarity, this assigns a bool to "buzz" that will come back true or false. It asks the question- is i % 5 Equal to zero? 
            // if the answer is true, then it will return True. The opposite if its not. This is used to test the if statement to determine
            // whether or not it is a legit statement and if it should print.
            bool buzz = i % 5 == 0;
            // The console will print Fizz, Buzz, FizzBuzz, or the number depending on what number is being checked by void Start.
            if (fizz && buzz)
                print("FizzBuzz");
            else if (fizz)
                print("Fizz");
            else if (buzz)
                print("Buzz");
            // This one is super important, and shows why you should use an Else loop- Forgetting it will cause the console 
            // to print out just a bunch of Fizzes and Buzzes with no apparent meaning. 
            else
                print(i);
        }
            if(death)
        {
            print("I like beef jerky");
            else if (!death)
                print("I still like beef jerky even though I'm aliveee");
            else
                print("I am going to make a game for my son.");
        }
            }
            }

 