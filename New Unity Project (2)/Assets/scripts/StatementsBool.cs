using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsBool : MonoBehaviour
{
    public bool student;
    public bool engineer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (student == true)
        // if(student) is the same which equals to true  
        {
            print("passed");
        }
        else
        {
            print("try again");
        }
        if (engineer == false)
        // if(!engineer) is the same which equals to false 
        {
            print("poor");
        }
        else
        {
            print("Rich");
        }
    }
}
