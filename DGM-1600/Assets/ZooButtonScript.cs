using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ZooButtonScript : MonoBehaviour {
    public string animal;
    public List<string> zooRoster = new List<string>();
    public GameObject zooListtxt;



    void Start() {
        zooRoster.Add("Monkey");
        zooRoster.Add("Elephant");
        zooRoster.Add("Alligator");
    }

    public void UpdateZooList() {
        zooListtxt.GetComponent<Text>().text = ListPrint();
    }


    public void AddAnimal() {
        if (animal != " ")  {
            if (zooRoster.Contains(animal) != true)
                zooRoster.Add(animal);
        }
    }

    public void RemoveAnimal() {
        if (zooRoster.Contains(animal) == true)
            zooRoster.Remove(animal);
    }

    public void ClearList() {
        zooRoster.Clear();
    }

    public string ListPrint() {
        string temp = ""; 
        foreach (string item in zooRoster) { temp += (" " + (item));
            Debug.Log(item);
        } 
        return temp;
    }
     
    //Last line
}