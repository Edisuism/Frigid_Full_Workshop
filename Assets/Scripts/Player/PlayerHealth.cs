using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject leftHeart;
    [SerializeField] private GameObject middleHeart;
    [SerializeField] private GameObject rightHeart;

    public bool DeductHealth()
    {
        //NOTE IMPORTANT METHODS: 
        //"SetActive(false)" , this sets the object preceding it to be inactive (you do not need the quotation marks)
        //"activeInHierarchy()" , this checks if the object preceding it is active or not, returning true if it is active (you do not need the quotation marks)

        //First check if right heart is active, if it is then remove it


        //Second, check if the middle heart is active, if it is then remove it


        //Third, check if the left heart is active, if it is then remove it and then "return false;" on a new line withn the brackets


        //Do not edit below this line
        return true;
    }

    public void Reset()
    {
        leftHeart.SetActive(true);
        middleHeart.SetActive(true);
        rightHeart.SetActive(true);
    }
}
