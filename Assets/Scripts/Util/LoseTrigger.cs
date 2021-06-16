using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //IMPORTANT METHODS:
        //other.CompareTag("Player")
        //LevelManager.Instance.LoseLevel();
        //fix this so that the player loses when they come into contact with this object.
    }
}
