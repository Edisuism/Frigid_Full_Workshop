using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    int _currentNumber;

    // Start is called before the first frame update
    void Start()
    {
        //Example Debug that shows up in console once
        Debug.Log("Hello World!");

        //Example of 'Get that number!'
        //How do I get the number 16?
        //How do I get the number 34?
        //How do I get the number 51?
        //How do I get the number 120?

        //Example of 'If only...'
        //What number do I get with the following commands?
        AddThree();
        if (_currentNumber > 4)
        {
            AddThree();
        }
        SubtractTwo();
        SubtractTwo();
        MultiplyNumber(5);
    }

    // Update is called once per frame
    void Update()
    {
        //Example Debug that shows up in console every frame
        Debug.Log("Spam Spam Spam");
    }


    //Examples of methods to challenge learners
    void AddThree()
    {
        _currentNumber = _currentNumber + 3;
    }

    void SubtractTwo()
    {
        _currentNumber = _currentNumber - 2;
    }

    // Examples of customiseable methods
    void AddToNumber(int amountToAdd)
    {
        _currentNumber = _currentNumber + amountToAdd;
    }

    void SubtractFromNumber(int amountToSubtract)
    {
        _currentNumber = _currentNumber + amountToSubtract;
    }

    void MultiplyNumber(int amountToMultiply)
    {
        _currentNumber = _currentNumber + amountToMultiply;
    }

    void DivideNumber(int amountToDivide)
    {
        _currentNumber = _currentNumber + amountToDivide;
    }
}
