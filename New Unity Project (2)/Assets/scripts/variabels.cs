using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variabels : MonoBehaviour
{

    int number = 9;
    float position = 8.1f;
    char letter = 'H';
    public string name = "Hossam";
    // Start is called before the first frame update
    void Start()
    {
        print(name);
        print(number);
        print("position = " + position);
        print("letter = " + letter);
    }

    // Update is called once per frame
    void Update()
    {
        //print("you're " + number);
    }
}
