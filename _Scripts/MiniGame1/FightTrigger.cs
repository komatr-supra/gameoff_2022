using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTrigger : MonoBehaviour
{
    [SerializeField] GameObject miniGame1;
    [SerializeField] bool wasTriggered = false;
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("fight triggered");
        if(!wasTriggered && other.CompareTag("Player")){
            wasTriggered = true;
            
        }
    }

    
}
