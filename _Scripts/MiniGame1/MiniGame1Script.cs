using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Script : MonoBehaviour
{
    [SerializeField] BoxCollider2D slider;
    [SerializeField] BoxCollider2D hitPoint;
    [SerializeField] GameObject item;
    [SerializeField] float itemSpeed = 1f;
    void Update()
    {
        if(Physics2D.IsTouching(slider, hitPoint)){
            item.transform.position = new Vector3(item.transform.position.x - itemSpeed * Time.deltaTime, 
                    item.transform.position.y, 
                    item.transform.position.z);
        }
        else{
            item.transform.position = new Vector3(item.transform.position.x + itemSpeed * Time.deltaTime, 
                    item.transform.position.y, 
                    item.transform.position.z);
        }
    }
}
