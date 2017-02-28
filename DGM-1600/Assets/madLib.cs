using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madLib : MonoBehaviour {

    	
    string randFromArray( string[] s)
    {
        return s[Random.Range(0, s.Length)] + " ";
    }
    
	void Start () {

        string[] insult1 = { "Artless", "Beslubbering", "Frothy", "Goatish", "Gleeking", "Mangled", "tottering", "Unmuzzled", "Venomous" };
        string[] insult2 = { "Beef-witted", "Fly-bitten", "Hell-hated", "Milk-livered", "Rump-fed", "Hedge-born", "Ill-breeding" };
        string[] insult3 = { "Baggage", "Codpiece", "Horn-Beast", "Canker-blossom", "Maggot-Pie", "Miscreant", "Ratsbane", "Boar-pig" };
        string[] adj1 = { "Magical", "Rabid", "God-Fearing", "Evangellical", "Ludicrous", "Cold, Dead", "Lifeless", "Vibrant", "Tentacled" };
        string[] fish1 = { "swordfish", "octopus", "clam", "jellyfish", "Starfish", "Sperm whale", "tuna" , "Soggy Boot" };
        string[] verb1 = { "run", "skip", "urinate", "drive", "dive", "frollick", "Exeprience feelings of heated anger", "Jump" };
        string[] noun1 = { "Brick", "Candy", "Telescope", "Polar Bear", "Security Guard", "Attractive Male", "Attractive Female", "Moving Vehicle", "Rodeo Clown" };
        string[] verb2 = { "Devour", "Depreciate", "Reccomend", "Flaunt", "Impersonate", "Burn", "Televise", "Salt", "Desaturate" };
        string[] noun2 = { "Nightgown", "First-Born", "Lingerie", "Left Elbow", "Decapitated head of George Washington", "Game of thrones Fanfiction", "First baby blanket", "Home-Made French Toast" };
        string[] kilverb = { "Decapitate", "Disembowel", "Kill", "Murder", "Strangle", "Drown", "BURN", "Remove the vital organs from", "Stab" };
        string[] relative = { "Sister!", "Brother!", "Uncle!", "Grandfather!", "Ex-Girlfriend!", "Celebrety Crush!", "Cousin!","9933455534356;;oooqqqqqqqqqw!", "Evil Son!" };
        string[] end = { "perished in a firey hellstorm for their transgressions", "Made up and didnt die", "Turned into a couple of spineless worms and ended up in jail", "Made up and robbed the nearest bank", "spontaniously burst into flames", "spontaniously turned into cockroaches", "woke up from a bad dream", "Made up and adopted a huge family and raised them in the countryside" };


        print("I said you were a " + randFromArray(insult1) + randFromArray(insult2) + randFromArray(insult3) + "and I wish you were never born! " +
            " Ever since you came back from the ocean with that " + randFromArray(adj1) + randFromArray(fish1) + "You have been acting extremely Strange. You always want to " +
            randFromArray(verb1) + "Toward the nearest " + randFromArray(noun1) +  "That you see! " + ".... At least I dont always " + randFromArray(verb2) + "My " + randFromArray(noun2) +
            "Every time I see a " + randFromArray(noun1) + ". " +
            "How could you? Now I have to " + randFromArray(kilverb) + "My only " + randFromArray(relative) + "                      " + "Eventually, they all " + randFromArray(end) +
            "    THE END    "
            
            );
 

    }


}
