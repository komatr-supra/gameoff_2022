using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MiniGame1End : MonoBehaviour
{
    [SerializeField] string winner = "not set";
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] float waitTime = 2f;    
    bool showWinner = false;
    private void Update() {
        if(!showWinner) return;
        if(waitTime > 0){
            waitTime -= Time.deltaTime;
        }
        else{
            textMeshPro.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canMove = true;
            transform.parent.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        textMeshPro.gameObject.SetActive(true);
        textMeshPro.text = winner;
        showWinner = true;        
    }
    
}
