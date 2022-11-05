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
            StartFight(other);
        }
    }

    private void StartFight(Collider2D playerColider)
    {
        miniGame1.transform.position = playerColider.transform.position;
        playerColider.gameObject.GetComponent<Mover>().canMove = false;
        miniGame1.SetActive(true);
    }
}
