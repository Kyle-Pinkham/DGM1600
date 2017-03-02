using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooButtonScript : MonoBehaviour {
    public string animal;
    public List<string> zooRoster = new List<string>();

    void start() {
        zooRoster.Add("Monkey");
        zooRoster.Add("Elephant");
        zooRoster.Add("Alligator");
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

    public void ListPrint() {
        foreach (string item in zooRoster) { print(item); }
    }
     
    //Last line
}