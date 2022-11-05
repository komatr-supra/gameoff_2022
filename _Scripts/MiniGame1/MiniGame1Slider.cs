using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Slider : MonoBehaviour
{
    [SerializeField] Vector2 spacePushPower = new Vector2(0, 2);
    Rigidbody2D rb2d;
    bool presed = false;
    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){presed = true;}
    }
    void FixedUpdate()
    {
        if(presed){
            presed = false;
            rb2d.AddForce(spacePushPower, ForceMode2D.Impulse);
        }
    }
}
