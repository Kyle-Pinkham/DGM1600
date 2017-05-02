using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class FinalSkript : MonoBehaviour {

    int divVariable;
    public int opTestNum1, opTestNum2, trainNum1, trainNum2, trainNum3;
    public bool inchesToFeet, feetToInches;
    public int feetInchNum; // This variable is declared seperately to allow for clarity in the unity interface.
    int[] Numbers = new int[5];

    void Start () {
        LazyProfessorMode();
        Helloworld();
        Operator(opTestNum1, opTestNum2);
        Listprint();
        FootConverter(feetInchNum);
        TrainProblem(trainNum1, trainNum2, trainNum3);
	}
	
    void Helloworld() {
        print("Hello! (world) My name is Kyle Pinkham. The current time is: " + DateTime.Now.Hour + " O' Clock " + "With " + DateTime.Now.Minute + " Minutes' on the hour!");
    }

    void Operator(float y , float x) {
        print("The operators for the numbers " + y + " and " + x + " Will give these results, for addition, subtraction, multiplication, and division, respectively: " + (x + y) + ", " + (x - y) + ", " +  (x * y) + ", " + (x / y));
        print(y + "+" + x + "=" + (y + x) + ", " + y + "-" + x + "=" + (y - x) + ", " + y + "*" + x + "=" + (y * x) + ", and " + y + "/" + x + "=" + (y / x));
    }

    void Listprint() {
        int numAverage;
        int numSum = Numbers.Sum();
            foreach( int number in Numbers) {
                ++divVariable;
            }
        numAverage = numSum / divVariable;
        print("The average of the numbers in my Numbers List is " + numAverage);
        // The same result could be given with: " public List<int> Numbers = new List<int>(); " and by doing this I would be able to not have a limit
        // on my numbers. however, by creating a predetermined array I can more easily allow you to maniuplate the variables as an instructor
    }

    void FootConverter(float x) {
        if (inchesToFeet) 
            print(x + " inches is the same as " + (x = x / 12) + " Feet.");
        //Space, for readability
        if (feetToInches)
                print(x + " Feet is the same as " + (x = x * 12) + " Inches.");
        //Space, for readability
        if ((feetToInches == false && inchesToFeet == false) || x == 0 )
            print("You know, if you don't want me to convert anything you don't need to have me make a converter for you.");
    }

    void TrainProblem(int wMph, int eMph, int hrs) {
        int x = (wMph * hrs) + (eMph * hrs);
        print("If a train leaves city A at " + wMph + " going West, and another train leaves the same city going east at "
            + eMph + ", Then after " + hrs + " hours of travel they will be " + x + " Miles apart from eachother.");
    }
    void LazyProfessorMode() {
            if (opTestNum2 == 0 && opTestNum1 == 0) {
                opTestNum1 = UnityEngine.Random.Range(0, 100);
                opTestNum2 = UnityEngine.Random.Range(0, 100);
            }
            if (trainNum1 == 0 && trainNum2 == 0 && trainNum3 == 0) {
                trainNum1 = UnityEngine.Random.Range(0, 100);
                trainNum2 = UnityEngine.Random.Range(0, 100);
                trainNum3 = UnityEngine.Random.Range(0, 100);
            }
    }
}
