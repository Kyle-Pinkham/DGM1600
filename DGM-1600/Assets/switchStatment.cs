using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchStatment : MonoBehaviour {

    private int time = 10;

    public string animal = "Alligator";
    private string phrase;
    private bool exists = true;
    
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
            default:
                exists = false;
                break;
        }

        if (exists)
            print("A " + animal + " says \"" + phrase + "\".");
        else
            print(animal + " does not exist.");
        
        switch(time)
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
		
	}

}
