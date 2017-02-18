using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchStatment : MonoBehaviour {

    private int time = 9;

    public string animal = "Alligator";
    private string phrase;
    private bool exists = true;
    private string television = "gameOfThrones";
    private int heartBeat = 10;
    public int cardNumber = 1;


    // Use this for initialization
    void start () {

        switch (animal)
        {
            case "Giraffe":
                phrase = "Wheezy neighbaaaah";
                break;
            case "Penguin":
                phrase = "Morgan Freeman";
                break;
            case "Fox":
                phrase = "whapapapapapapow";
                break;
            case "Alligator":
                phrase = "Would you like some tea with that, sir?";
                break;
            case "Horse":
                phrase = "Doctorate Denied";
                break;
            case "Narwhals":
                phrase = "YOUR JOURNEY TO THE DARK SIDE IS COMPLETE";
                break;
            default:
                exists = false;
                break;
        }

        if (exists)
            print("A " + animal + " says \"" + phrase + "\".");
        else
            print(animal + " does not exist.");

        switch (time)
        {
            case 9:
                print("good morning!");
                break;
            case 12:
                print("Lunch Time!");
                break;
            case 18:
                print("Get the heck out of the office right now you slime");
                break;
            default:
                print("get back to work, slime!!~");
                break;
        }

        switch(television)
                {
             case "gameOfThrones":
                   heartBeat = 10;
                   break;
             case "Bones":
                   heartBeat = 10;
                   break;
            case "rickandMorty":
                   heartBeat = 50;
                   break;
            default:
                   heartBeat = 1;
                   break;
                }
        // This will test to see if a card number is a number card or a face card
        switch (cardNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                print("Number card!");
                break;
            case 11:
            case 12:
            case 13:
                print("Face Card!");
                break;
            default:
                print("Cmon man that isn't a card");
                break;
        }
        // This tests two things: one, if I have a case that changes the case to an alternate case, will it still run? it should (it does)
        // Secondly, can you run a switch statement without a default? (Yes.) Though for clarification, you should usually, if not always, include a default value in case it comes back with an improper value.
          switch (heartBeat)
                {
            case 5:
                heartBeat = 10;
                print("Why did this make my heartbeat increase? im not sure");
                break;
            case 10:
                heartBeat = 15;
                print("Why did this make my heartbeat increase? I'm not sure");
                break;
            case 15:
                heartBeat = 20;
                print("This shouldn't even be a thingggg");
                break;
            
                }
     }

}


