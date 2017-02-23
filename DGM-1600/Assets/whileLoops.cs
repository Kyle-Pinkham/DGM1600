using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileLoops : MonoBehaviour {
    //public int bottles = 0;
    //public int maxBottles = 100;
    public bool gameOn = true;
    private int randomNum;
    private int minVal = 1;
    private int maxVal = 71;
    private int myNum = 7;
    private int counter = 0;

    // Create a random number generator with while loops

	void Start () {
        while (gameOn == true)
        {
            randomNum = Random.Range(minVal, maxVal);
            if (randomNum == myNum) { 
                print("Awesome! " + randomNum + " = " + myNum);
            break; }
                else
                {

                print(randomNum + "? That isn't the right number, you are looking for " + myNum + ".");
                counter++;
                if (randomNum < myNum)
                    minVal = randomNum;
                if (randomNum > myNum)
                    maxVal = randomNum;


                if (counter >= 600)
                    break;
                }
            
        }
        print("You went thorough " + counter + " random attempts");
    }
}


//while (gameOn)
//{
//    print(bottles + "bottles of COLD VODKA");
//    bottles++;
//    if (bottles == maxBottles)
//    {
//        gameOn = false;
//    }
//}


/*   while(bottles <= maxBottles) {
            if (bottles % 2 == 0)  {
                print(bottles + "of r00t beer on the wallA");
            }

            bottles++;

        }
*/
